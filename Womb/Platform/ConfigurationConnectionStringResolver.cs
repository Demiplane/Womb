using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Platform
{
    public sealed class ConfigurationConnectionStringResolver : IConnectionStringResolver
    {
        private IConfiguration configuration;

        public ConfigurationConnectionStringResolver(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task<string> ResolveConnectionString(string connectionStringName)
        {
            return Task.FromResult(this.configuration.GetConnectionString(connectionStringName));
        }
    }
}
