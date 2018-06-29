using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Womb.WordResolver
{
    public class NonCommonWordResolver : IWordResolver
    {
        private const string wordsFileLocation = "wwwroot/misc/words.txt";
        private const string commonWordsFileLocation = "wwwroot/misc/commonWords.txt";

        private SemaphoreSlim wordLock = new SemaphoreSlim(1);

        private IFileProvider fileProvider;

        private IList<string> usableWords;
        private Random random = new Random();
        private bool shouldDetermineUsableWords = true;

        public NonCommonWordResolver(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        public async Task<string> ResolveWord()
        {

            if (shouldDetermineUsableWords)
            {
                await wordLock.WaitAsync();
                if (shouldDetermineUsableWords)
                {
                    usableWords = (await this.ReadWords()).Except(await this.ReadCommonWords()).ToList();
                    this.shouldDetermineUsableWords = false;
                }
            }
            var randomWord = usableWords.Random();

            return randomWord;
        }

        private async Task<List<string>> ReadCommonWords()
        {
            var commonWords = new List<string>();

            var fileInfo = this.fileProvider.GetFileInfo(commonWordsFileLocation);

            using (var stream = fileInfo.CreateReadStream())
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    commonWords.Add((await reader.ReadLineAsync()).Trim().ToUpperInvariant());
                }
            }

            return commonWords;
        }

        private async Task<List<string>> ReadWords()
        {
            var words = new List<string>();
            var fileInfo = this.fileProvider.GetFileInfo(wordsFileLocation);

            using (var stream = fileInfo.CreateReadStream())
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    words.Add((await reader.ReadLineAsync()).Trim().ToUpperInvariant());
                }
            }

            return words;
        }
    }
}
