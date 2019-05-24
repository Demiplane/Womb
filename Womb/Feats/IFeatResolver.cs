using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Feats
{
    public interface IFeatResolver
    {
        IEnumerable<Feat> ResolveFeats();
    }
}
