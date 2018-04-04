using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Platform
{
    public interface ICreationCountRepository
    {
        Task<int> UpdateCreationCount();
    }
}
