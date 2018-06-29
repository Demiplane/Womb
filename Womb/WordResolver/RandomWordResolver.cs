using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.WordResolver
{
    public class RandomWordResolver : IWordResolver
    {
        private Random random = new Random();

        private IList<string> words = new List<string>();

        private IFileProvider fileProvider;

        public RandomWordResolver(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public async Task<string> ResolveWord()
        {
            if (words.Count() == 0)
            {
                await FillWordsFromFile();
            }

            return words.Random();
        }

        private async Task FillWordsFromFile()
        {
            var fileInfo = this.fileProvider.GetFileInfo("wwwroot/misc/words.txt");

            using (var stream = fileInfo.CreateReadStream())
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    words.Add((await reader.ReadLineAsync()).Trim().ToUpperInvariant());
                }
            }
        }
    }
}
