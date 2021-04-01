using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace remixed_recipes.Services
{
    public class UserService
    {
        public readonly IHttpContextAccessor _context;

        public UserService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetNameIdentifier()
        {
            return _context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
