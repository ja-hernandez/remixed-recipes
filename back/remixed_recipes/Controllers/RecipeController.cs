using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using remixed_recipes.Data;
using remixed_recipes.Helpers;
using remixed_recipes.Models;
using remixed_recipes.Services;
using remixed_recipes.Controllers;
using remixed_recipes.Models.Accounts;

namespace remixed_recipes.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : BaseAuthController
    {
        private readonly ApiDBContext _context;
        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IAccountService _accountService;


        public RecipeController(ApiDBContext context, IConfiguration config, IHttpClientFactory clientFactory, IAccountService accountService)
        {
            _context = context;
            _config = config;
            _clientFactory = clientFactory;
            _accountService = accountService;
        }

        // GET: api/Recipe
        ///<summary>
        ///Pulls all recipes
        /// </summary>

        [HttpPost("authenticate")]
        public ActionResult<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var response = _accountService.Authenticate(model, ipAddress());
            setTokenCookie(response.RefreshToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        {
            return await _context.Recipes
                .AsNoTracking()
                .ToListAsync()
                ;
        }




        /// <summary>
        /// This method shows all blogs by title
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET: api/Recipe/5
        /// </remarks>
        // GET: api/Recipe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipe(int id)
        {


            var recipe = await _context.Recipes
                .Include(r => r.Instructions)
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Quantity)
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Unit)
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Preparation)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        // PUT: api/Recipe/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipe(int id, Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return BadRequest();
            }

            _context.Entry(recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Recipe
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Recipe>> PostRecipe(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            try
            {
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetRecipe", new { id = recipe.Id }, recipe);
            }
            catch
            {
                throw;
            }



        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        // DELETE: api/Recipe/5
        [Authorize(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recipe>> DeleteRecipe(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();

            return recipe;
        }

        [HttpGet("GetExt")]
        public async Task<ActionResult<Recipe>> AddExtRecipe()
        {
            Recipe recipe = new Recipe();
            var recipeApiKey = _config["Recipes:ApiKey"];
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.spoonacular.com/recipes/random?apiKey=" + recipeApiKey + "&limitLicense=true&number=1");

            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                JObject returnedRecipe = JObject.Parse(responseStream);

                IList<JToken> recipeIngredients = returnedRecipe["recipes"][0]["extendedIngredients"].Children().ToList();
                JToken recipeName = returnedRecipe["recipes"][0]["title"].ToString();
                JToken recipeInstructions = returnedRecipe["recipes"][0]["instructions"].ToString();
                JToken recipeImage = returnedRecipe["recipes"][0]["image"].ToString();

                JObject recipeJson =
                    new JObject(
                        new JProperty("createdDate", DateTime.UtcNow),
                        new JProperty("createdBy",
                            new JObject(
                                new JProperty("id", 1)
                                )
                            ),
                        new JProperty("name", ""),
                        new JProperty("instructions",
                            new JObject(
                                new JProperty("")
                        )));

                IList<RecipeIngredient> parsedRecIngredients = new List<RecipeIngredient>();


                recipe.Name = recipeName.ToString();
                recipe.Instructions.InstructionsText = recipeInstructions.ToString();

                return recipe;
            }
            else return BadRequest();


        }

        // helper methods

        private void setTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        private string ipAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }


        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}

