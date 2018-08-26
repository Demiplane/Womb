using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models
{
    public static class ModelExtentions
    {
        public static List<Background> AllBackgrounds = new List<Background>()
        {
            Background.Acolyte,
            Background.Anthropologist,
            Background.Archeologist,
            Background.Charlatan,
            Background.CityWatch,
            Background.ClanCrafter,
            Background.CloisteredScholor,
            Background.Courtier,
            Background.Criminal,
            Background.Entertainer,
            Background.FactionAgent,
            Background.FarTraveler,
            Background.FolkHero,
            Background.Gladiator,
            Background.GuildArtisan,
            Background.GuildMerchant,
            Background.HauntedOne,
            Background.Hermit,
            Background.Inheritor,
            Background.Investigator,
            Background.Knight,
            Background.KnightOrder,
            Background.MerceneryVeteran,
            Background.Noble,
            Background.Outlander,
            Background.Pirate,
            Background.Sage,
            Background.Sailor,
            Background.Soldier,
            Background.Spy,
            Background.UrbanBountyHunter,
            Background.Urchin,
            Background.UthgardtTribeMember,
            Background.WaterdhavianNoble,
        };

        public static List<RaceName> AllRaces = new List<RaceName>()
        {
            RaceName.Dragonborn,
            RaceName.Dwarf,
            RaceName.Elf,
            RaceName.Gnome,
            RaceName.HalfElf,
            RaceName.HalfOrc,
            RaceName.Halfling,
            RaceName.Human,
            RaceName.Tiefling,
            RaceName.Aasimar,
            RaceName.Bugbear,
            RaceName.Firbolg,
            RaceName.Goblin,
            RaceName.Hobgoblin,
            RaceName.Kenku,
            RaceName.Kobold,
            RaceName.Lizardfolk,
            RaceName.Orc,
            RaceName.Tabaxi,
            RaceName.Triton
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

        private static IDictionary<RaceName, string> RaceFormatMap = new Dictionary<RaceName, string>
        {
            { RaceName.HalfElf, "Half-Elf" },
            { RaceName.HalfOrc, "Half-Orc" },
            { RaceName.YuanTi, "Yuan-Ti" },
        };

        private static IDictionary<Background, string> BackgroundFormatMap = new Dictionary<Background, string>
        {
            { Background.CityWatch, "City Watch"},
            { Background.ClanCrafter, "Clan Crafter"},
            { Background.CloisteredScholor, "Cloistered Scholor"},
            { Background.FactionAgent, "Faction Agent"},
            { Background.FarTraveler, "Far Traveler"},
            { Background.FolkHero, "Folk Hero"},
            { Background.GuildArtisan, "Guild Artisan"},
            { Background.GuildMerchant, "Guild Merchant"},
            { Background.HauntedOne, "Haunted One"},
            { Background.KnightOrder, "Knight of the Order"},
            { Background.MerceneryVeteran, "Mercenary Veteran"},
            { Background.UrbanBountyHunter, "Urban Bounty Hunter"},
            { Background.UthgardtTribeMember, "Uthgardt Tribe Member"},
            { Background.WaterdhavianNoble, "Waterdhavian Noble"},
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
            {Class.Warlock,  new List<string>() {"Pact of the Archfey", "Pact of the Celestial", "Pact of the Fiend", "Pact of the Great Old One", "Pact of the Hexblade", "Pact of the Undying"}},
            {Class.Wizard,   new List<string>() {"Bladesinging", "School of Abjuration", "School of Conjuration", "School of Divination", "School of Enchantment", "School of Evocation", "School of Illusion", "School of Necromancy", "School of Transmutation", "War Magic"}},
        };

        private static IDictionary<RaceName, List<string>> SubraceDictionary = new Dictionary<RaceName, List<string>>()
        {
            {RaceName.Dragonborn,new List<string>() {"Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White"} },
            {RaceName.Dwarf,     new List<string>() {"Hill", "Mountain", "Duergar"} },
            {RaceName.Elf,       new List<string>() {"High", "Wood", "Dark"} },
            {RaceName.Gnome,     new List<string>() {"Forest", "Rock"} },
            {RaceName.HalfElf,   new List<string>() {} },
            {RaceName.HalfOrc,   new List<string>() {} },
            {RaceName.Halfling,  new List<string>() {"Lightfoot", "Stout"} },
            {RaceName.Human,     new List<string>() {} },
            {RaceName.Tiefling,  new List<string>() {} },
            {RaceName.Aasimar,   new List<string>() {} },
            {RaceName.Bugbear,   new List<string>() {} },
            {RaceName.Firbolg,   new List<string>() {} },
            {RaceName.Goblin,    new List<string>() {} },
            {RaceName.Hobgoblin, new List<string>() {} },
            {RaceName.Kenku,     new List<string>() {} },
            {RaceName.Kobold,    new List<string>() {} },
            {RaceName.Lizardfolk,new List<string>() {} },
            {RaceName.Orc,       new List<string>() {} },
            {RaceName.Tabaxi,    new List<string>() {} },
            {RaceName.Triton,    new List<string>() {} },
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

        public static string ChooseRandomSubrace(this RaceName race)
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


        public static string Format(this Background background)
        {
            if (BackgroundFormatMap.ContainsKey(background))
            {
                return BackgroundFormatMap[background];
            }
            else
            {
                return background.ToString();
            }
        }

        public static string Format(this RaceName race)
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
