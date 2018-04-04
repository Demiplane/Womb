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
        private ICreationCountRepository creationCountRepository;

        public HomeController(IWordResolver wordResolver, ICreationCountRepository creationCountRepository)
        {
            this.wordResolver = wordResolver;
            this.creationCountRepository = creationCountRepository;
        }

        public async Task<IActionResult> Index()
        {
            var character = new Character();
            character.Name = wordResolver.ResolveWord() + " " + wordResolver.ResolveWord();
            character.Class = ModelExtentions.AllClasses.Random();
            character.Race = ModelExtentions.AllRaces.Random();
            character.Subclass = character.Class.ChooseRandomSubclass();
            character.Subrace = character.Race.ChooseRandomSubrace();
            character.Stats = Statistics.RollAll();
            character.Background = ModelExtentions.AllBackgrounds.Random();

            var characterCreationCount = await this.creationCountRepository.UpdateCreationCount();

            var characterCreation = new CharacterCreationViewModel() { CharacterViewModel = new CharacterViewModel(character), CharacterCreationCount = characterCreationCount };

            return View("CharacterCreationView", characterCreation);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
