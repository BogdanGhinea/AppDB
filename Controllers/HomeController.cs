using AppDatenB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDatenB.Controllers
{
    public class HomeController : Controller
    {
        private NewsApplicationContext ctx;
        public HomeController(NewsApplicationContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {            
            return View(ctx.Articles.ToList());
        }
    }
}
