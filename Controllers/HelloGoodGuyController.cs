using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloGoodGuyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}