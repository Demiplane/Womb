using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Womb.Models;
using Womb.NameGeneration;
using Womb.Platform;
using Womb.ViewModels;
using Womb.WordResolver;

namespace Womb.Controllers
{
    public class CharacterController : Controller
    {
        private INameGenerator nameGenerator;
        private ICreationCountRepository creationCountRepository;
        private ICharacterSaver characterSaver;

        public CharacterController(INameGenerator nameGenerator, ICreationCountRepository creationCountRepository, ICharacterSaver characterSaver)
        {
            this.nameGenerator = nameGenerator;
            this.creationCountRepository = creationCountRepository;
            this.characterSaver = characterSaver;
        }

        public async Task<IActionResult> Birth()
        {
            var character = new Character();
            character.Name = await this.nameGenerator.GenerateName(NameGenerationOptions.None);
            character.Class = ModelExtentions.AllClasses.Random();
            character.Race = Race.StandardRaces().Random();
            character.Subclass = character.Class.ChooseRandomSubclass();
            character.Subrace = character.Race.Name.ChooseRandomSubrace();
            character.Stats = Statistics.RollAll();
            character.Background = ModelExtentions.AllBackgrounds.Random();

            foreach (var modifier in character.Race.Modifiers)
            {
                if (character.Stats.ContainsKey(modifier.Key))
                {
                    character.Stats[modifier.Key] += modifier.Value;
                }
            }

            var characterCreationCount = await this.creationCountRepository.UpdateCreationCount();

            var characterCreation = new CharacterCreationViewModel() { CharacterViewModel = new CharacterViewModel(character), CharacterCreationCount = characterCreationCount };

            return View("CharacterCreationView", characterCreation);
        }

        public async Task<IActionResult> SavedCharacters()
        {
            await Task.Delay(0);
            return Ok();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
