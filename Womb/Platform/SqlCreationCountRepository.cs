using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Platform
{
    public class SqlCreationCountRepository : ICreationCountRepository
    {
        private IConnectionStringResolver connectionStringResolver;

        public SqlCreationCountRepository(IConnectionStringResolver connectionStringResolver)
        {
            this.connectionStringResolver = connectionStringResolver;
        }

        public async Task<int> UpdateCreationCount()
        {
            var characterCreationCount = 0;

            var connectionString = await connectionStringResolver.ResolveConnectionString("DefaultConnectionString");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("Creation.GetCharacterCreationCount", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            characterCreationCount = reader.GetInt32(reader.GetOrdinal("CreationCount"));
                        }
                    }
                }
            }

            return characterCreationCount;
        }
    }
}
