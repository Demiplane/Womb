using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.WordResolver
{
    public interface IWordResolver
    {
        Task<string> ResolveWord();
    }
}
