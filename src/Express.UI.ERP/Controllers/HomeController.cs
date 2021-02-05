using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Express.UI.ERP.Controllers
{
    public class HomeController : Controller
    {
        //Faz com que seja retornada a view padrao ligada a controller, no caso a Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
    