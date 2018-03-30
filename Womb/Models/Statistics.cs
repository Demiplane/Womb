using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Models
{
    public static class Statistics
    {
        private static Random random = new Random();

        public static IDictionary<string, int> RollAll()
        {
            var statDictionary = new Dictionary<string, int>();
            var stats = new List<string>() { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };

            foreach (var stat in stats)
            {
                statDictionary.Add(stat, GetStatistic());
            }

            return statDictionary;
        }

        private static int GetStatistic()
        {
            var rolls = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                rolls.Add(random.Next(1, 7));
            }

            var orderedRolls = rolls.OrderByDescending(i => i);

            return orderedRolls.Take(3).Aggregate((i1, i2) => i1 + i2);
        }
    }
}
