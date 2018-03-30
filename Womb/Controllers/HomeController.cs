using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Womb.Models;
using Womb.ViewModels;

namespace Womb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var character = new CharacterViewModel() { Name = "Kaldrod Beginnings", Class = "Ranger", Race = "Orc" };
            return View("CharacterView", character);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
