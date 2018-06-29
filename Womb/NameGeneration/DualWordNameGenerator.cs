using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Platform;
using Womb.WordResolver;

namespace Womb.NameGeneration
{
    public class DualWordNameGenerator : INameGenerator
    {
        private IWordResolver wordResolver;

        public DualWordNameGenerator(IWordResolver wordResolver)
        {
            this.wordResolver = wordResolver;
        }

        public async Task<string> GenerateName(NameGenerationOptions options)
        {
            return (await this.wordResolver.ResolveWord()) + " " + (await this.wordResolver.ResolveWord());
        }
    }
}
