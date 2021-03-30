using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using remixed_recipes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace remixed_recipes.Controllers
{
    [Controller]
    public abstract class BaseAuthController : ControllerBase
    {
        public Account Account => (Account)HttpContext.Items["Account"];
    }
}
