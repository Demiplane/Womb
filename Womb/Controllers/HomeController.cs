using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Womb.Models;
using Womb.Platform;
using Womb.ViewModels;

namespace Womb.Controllers
{
    public class HomeController : Controller
    {
        private IWordResolver wordResolver;

        public HomeController(IWordResolver wordResolver)
        {
            this.wordResolver = wordResolver;
        }

        public IActionResult Index()
        {
            var character = new Character();
            character.Name = wordResolver.ResolveWord() + " " + wordResolver.ResolveWord();
            character.Class = ModelExtentions.AllClasses.Random();
            character.Race = ModelExtentions.AllRaces.Random();
            character.Subclass = character.Class.ChooseRandomSubclass();
            character.Subrace = character.Race.ChooseRandomSubrace();
            character.Stats = Statistics.RollAll();
            character.Background = ModelExtentions.AllBackgrounds.Random();

            return View("CharacterView", new CharacterViewModel(character));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
