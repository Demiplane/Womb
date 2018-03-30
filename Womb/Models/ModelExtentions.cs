using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models
{
    public static class ModelExtentions
    {
        public static List<Race> AllRaces = new List<Race>()
        {
            Race.Dragonborn,
            Race.Dwarf,
            Race.Elf,
            Race.Gnome,
            Race.HalfElf,
            Race.HalfOrc,
            Race.Halfling,
            Race.Human,
            Race.Tiefling,
            Race.Aasimar,
            Race.Bugbear,
            Race.Firbolg,
            Race.Goblin,
            Race.Hobgoblin,
            Race.Kenku,
            Race.Kobold,
            Race.Lizardfolk,
            Race.Orc,
            Race.Tabaxi,
            Race.Triton
        };

        public static List<Class> AllClasses = new List<Class>()
        {
            Class.Barbarian,
            Class.Bard,
            Class.Cleric,
            Class.Druid,
            Class.Fighter,
            Class.Monk,
            Class.Paladin,
            Class.Ranger,
            Class.Rogue,
            Class.Sorcerer,
            Class.Warlock,
            Class.Wizard,
        };

        private static IDictionary<Race, string> RaceFormatMap = new Dictionary<Race, string>
        {
            { Race.HalfElf, "Half-Elf" },
            { Race.HalfOrc, "Half-Orc" },
        };

        private static IDictionary<Class, List<string>> SubclassDictionary = new Dictionary<Class, List<string>>()
        {
            {Class.Barbarian,new List<string>() {"Path of the Berserker", "Path of the Totem Warrior", "Path of the Ancestral Guardian", "Path of the Battlerager", "Path of the Storm Herald", "Path of the Zealot"}},
            {Class.Bard,     new List<string>() {"College of Glamour", "College of Lore", "College of Swords", "College of Valor", "College of Whispers"}},
            {Class.Cleric,   new List<string>() {"Arcana Domain", "Death Domain", "Forge Domain", "Grave Domain", "Knowledge Domain", "Life Domain", "Light Domain", "Nature Domain", "Tempest Domain", "Trickery Domain", "War Domain"}},
            {Class.Druid,    new List<string>() {"Circle of Dreams", "Circle of the Land", "Circle of the Moon", "Circle of the Shepherd"}},
            {Class.Fighter,  new List<string>() {"Arcane Archer", "Banneret/Purple Dragon Knight", "Battle Master", "Cavalier", "Champion", "Eldritch Knight", "Samurai"}},
            {Class.Monk,     new List<string>() {"Way of the Drunken Master", "Way of the Four Elements", "Way of the Kensei", "Way of the Long Death", "Way of the Open Hand", "Way of the Shadow", "Way of the Sun Soul"}},
            {Class.Paladin,  new List<string>() {"Oath of the Ancients", "Oath of Conquest", "Oath of the Crown", "Oath of Devotion", "Oath of Redemption", "Oath of Vengeance", "Oathbreaker"}},
            {Class.Ranger,   new List<string>() {"Beastmaster", "Gloom Stalker", "Horizon Walker", "Hunter", "Monster Slayer"}},
            {Class.Rogue,    new List<string>() {"Arcane Trickster", "Assassin", "Inquisitive", "Mastermind", "Scout", "Sqashbuckler", "Theif"}},
            {Class.Sorcerer, new List<string>() {"Divine Soul", "Draconic Bloodline", "Shadow Magic", "Storm Sorcery", "Wild Magic"}},
            {Class.Warlock,  new List<string>() {"The Archfey", "The Celestial", "The Fiend", "The Great Old One", "The Hexblade", "The Undying"}},
            {Class.Wizard,   new List<string>() {"Bladesinging", "School of Abjuration", "School of Conjuration", "School of Divination", "School of Enchantment", "School of Evocation", "Schhool of Illusion", "School of Necromancy", "Schol of Transmutation", "War Magic"}},
        };

        private static IDictionary<Race, List<string>> SubraceDictionary = new Dictionary<Race, List<string>>()
        {
            {Race.Dragonborn,new List<string>() {"Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White"} },
            {Race.Dwarf,     new List<string>() {"Hill Dwarf", "Mountain Dwarf", "Duergar"} },
            {Race.Elf,       new List<string>() {"High Elf", "Wood Elf", "Dark Elf"} },
            {Race.Gnome,     new List<string>() {"Forest Gnome", "Rock Gnome"} },
            {Race.HalfElf,   new List<string>() {} },
            {Race.HalfOrc,   new List<string>() {} },
            {Race.Halfling,  new List<string>() {"Lightfoot", "Stout"} },
            {Race.Human,     new List<string>() {} },
            {Race.Tiefling,  new List<string>() {} },
            {Race.Aasimar,   new List<string>() {} },
            {Race.Bugbear,   new List<string>() {} },
            {Race.Firbolg,   new List<string>() {} },
            {Race.Goblin,    new List<string>() {} },
            {Race.Hobgoblin, new List<string>() {} },
            {Race.Kenku,     new List<string>() {} },
            {Race.Kobold,    new List<string>() {} },
            {Race.Lizardfolk,new List<string>() {} },
            {Race.Orc,       new List<string>() {} },
            {Race.Tabaxi,    new List<string>() {} },
            {Race.Triton,    new List<string>() {} },
        };

        public static string ChooseRandomSubclass(this Class @class)
        {
            if (SubclassDictionary.ContainsKey(@class))
            {
                return SubclassDictionary[@class].Random();
            }
            else
            {
                return "";
            }
        }

        public static string ChooseRandomSubrace(this Race race)
        {
            if (SubraceDictionary.ContainsKey(race))
            {
                return SubraceDictionary[race].Random();
            }
            else
            {
                return "";
            }
        }


        public static string Format(this Race race)
        {
            if (RaceFormatMap.ContainsKey(race))
            {
                return RaceFormatMap[race];
            }
            else
            {
                return race.ToString();
            }
        }
    }
}
