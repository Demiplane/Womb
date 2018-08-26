using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models
{
    public class Race
    {
        public RaceName Name
        {
            get;
            set;
        }

        public IDictionary<string, int> Modifiers
        {
            get;
            set;
        } = new Dictionary<string, int>();


        public static IEnumerable<Race> StandardRaces()
        {
            return new List<Race>()
            {
                new Race() { Name = RaceName.Dragonborn, Modifiers = new Dictionary<string, int>() { { "Strength", 2 }, { "Charisma", 1 } } },
                new Race() { Name = RaceName.Dwarf, Modifiers = new Dictionary<string, int>() { { "Strength", 2 }, { "Wisdom", 1 } } },
                new Race() { Name = RaceName.Elf, Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Wisdom", 1 } } },
                new Race() { Name = RaceName.Gnome, Modifiers = new Dictionary<string, int>() { { "Constitution", 1 }, { "Intelligence", 2 } } },
                new Race() { Name = RaceName.HalfElf, Modifiers = new Dictionary<string, int>() { { "Dexterity", 1 }, { "Charisma", 2 } } },
                new Race() { Name = RaceName.HalfOrc, Modifiers = new Dictionary<string, int>() { { "Strength", 2 } } },
                new Race() { Name = RaceName.Halfling, Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Constitution", 1 } } },
                new Race() { Name = RaceName.Human, Modifiers = new Dictionary<string, int>() { { "Dexterity", 1 }, { "Strenth", 1 }, { "Charisma", 1 }, {"Intelligence", 1 }, { "Constitution", 1 }, { "Wisdom", 1 } } }, //TODO
                new Race() { Name = RaceName.Tiefling, Modifiers = new Dictionary<string, int>() { { "Dex", 2 }, { "Intelligence", 1} } }, //TODO
                new Race() { Name = RaceName.Aasimar, Modifiers = new Dictionary<string, int>() { { "Wisdom", 1 }, { "Charisma", 2 } } },
                new Race() { Name = RaceName.Bugbear, Modifiers = new Dictionary<string, int>() { { "Strength", 2 }, { "Dexterity", 1 } } },
                new Race() { Name = RaceName.Firbolg, Modifiers = new Dictionary<string, int>() { { "Strength", 1 }, { "Wisdom", 2} } },
                new Race() { Name = RaceName.Goblin, Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Constitution", 1 } } },
                new Race() { Name = RaceName.Hobgoblin, Modifiers = new Dictionary<string, int>() { { "Strength", 2 }, { "Constitution", 1} } }, //TODO
                new Race() { Name = RaceName.Kenku, Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Intelligence", 1} } }, // TODO
                new Race() { Name = RaceName.Kobold, Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 } } }, //TODO
                new Race() { Name = RaceName.Lizardfolk, Modifiers = new Dictionary<string, int>() { { "Constitution", 2 } } }, // TODO
                new Race() { Name = RaceName.Orc, Modifiers = new Dictionary<string, int>() { { "Strength", 2 }, { "Constitution", 1 } } }, // TODO
                new Race() { Name = RaceName.Tabaxi, Modifiers = new Dictionary<string, int>() { { "Dex", 1 } } }, // TODO
                new Race() { Name = RaceName.Triton,  Modifiers = new Dictionary<string, int>() { { "Dex", 1 } } }, // TODO
                new Race() { Name = RaceName.Aarakocra,  Modifiers = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Wisdom", 1 } } } //TODO
            };
        }

    }
}
