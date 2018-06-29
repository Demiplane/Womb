using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.NameGeneration
{
    public interface INameGenerator
    {
        Task<string> GenerateName(NameGenerationOptions options);
    }
}
