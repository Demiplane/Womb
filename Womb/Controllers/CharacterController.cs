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
    public class CharacterController : Controller
    {
        private IWordResolver wordResolver;
        private ICreationCountRepository creationCountRepository;
        private ICharacterSaver characterSaver;

        public CharacterController(IWordResolver wordResolver, ICreationCountRepository creationCountRepository, ICharacterSaver characterSaver)
        {
            this.wordResolver = wordResolver;
            this.creationCountRepository = creationCountRepository;
            this.characterSaver = characterSaver;
        }

        public async Task<IActionResult> Birth()
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

        public async Task<IActionResult> SavedCharacters()
        {
            await Task.Delay(0);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Character character)
        {
            if (String.IsNullOrWhiteSpace(character.Name))
            {
                character = new Character();
                character.Name = wordResolver.ResolveWord() + " " + wordResolver.ResolveWord();
                character.Class = ModelExtentions.AllClasses.Random();
                character.Race = ModelExtentions.AllRaces.Random();
                character.Subclass = character.Class.ChooseRandomSubclass();
                character.Subrace = character.Race.ChooseRandomSubrace();
                character.Stats = Statistics.RollAll();
                character.Background = ModelExtentions.AllBackgrounds.Random();
            }

            await this.characterSaver.Save(character, Guid.Empty);
            return Ok();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
