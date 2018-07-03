using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models.Names;
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

        public async Task<Name> GenerateName(NameGenerationOptions options)
        {
            return new TwoPartName() { FirstName = await this.wordResolver.ResolveWord(), LastName = await this.wordResolver.ResolveWord() };
        }
    }
}
