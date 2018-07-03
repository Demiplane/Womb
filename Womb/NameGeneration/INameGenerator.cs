using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models.Names;

namespace Womb.NameGeneration
{
    public interface INameGenerator
    {
        Task<Name> GenerateName(NameGenerationOptions options);
    }
}
