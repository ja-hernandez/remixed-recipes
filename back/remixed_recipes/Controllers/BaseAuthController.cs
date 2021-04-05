using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using remixed_recipes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace remixed_recipes.Controllers
{
    [Controller]
    public abstract class BaseAuthController : ControllerBase
    {
        // returns the current authenticated account (null if not logged in)
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}
