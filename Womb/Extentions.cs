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
        //public static Lazy<EnglishDictionary> Dictionary = new Lazy<EnglishDictionary>(() => new EnglishDictionary());

        //public static bool IsWord(string word)
        //{
        //    return Dictionary.Value.Words.Contains(word.ToUpperInvariant());
        //}

        //public static string RandomWord(this Random random)
        //{
        //    return Dictionary.Value.Words.Random(random);
        //}

        //public class EnglishDictionary
        //{
        //    internal IList<string> Words
        //    {
        //        get;
        //        set;
        //    } = new List<string>();

        //    internal EnglishDictionary()
        //    {
        //        this.Initialize();
        //    }

        //    private void Initialize()
        //    {

        //        var file = Path.Combine(Directory.GetCurrentDirectory(), "misc", "words.txt");
        //        var fileInfo = new FileInfo(file);

        //        using (var reader = fileInfo.OpenText())
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                Words.Add(reader.ReadLine().Trim().ToUpperInvariant());
        //            }
        //        }
        //    }
        //}

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
