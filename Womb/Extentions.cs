using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Womb
{
    public static class Extentions
    {
        private static Random random = new Random();

        public static string GetModifierForValue(this int number)
        {
            var modifier = (int)Math.Floor((number - 10) / 2f);

            if (modifier > 0)
            {
                return $"+{modifier}";
            }

            return modifier + "";
        }

        public static T Random<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return default(T);
            }

            var count = enumerable.Count();
            if (count == 0)
            {
                return default(T);
            }

            return enumerable.ElementAt(random.Next(0, count));

        }

        public static T Random<T>(this IEnumerable<T> enumerable, Random myRandom)
        {
            if (enumerable == null)
            {
                return default(T);
            }

            var count = enumerable.Count();
            if (count == 0)
            {
                return default(T);
            }

            return enumerable.ElementAt(myRandom.Next(0, count));

        }
    }
}
