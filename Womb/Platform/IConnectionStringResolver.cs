using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Platform
{
    public interface IConnectionStringResolver
    {
        Task<string> ResolveConnectionString(string connectionStringName);    
    }
}
