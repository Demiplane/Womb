using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Womb.Models;

namespace Womb.Platform
{
    public class SqlCharacterSaver : ICharacterSaver
    {
        private IConnectionStringResolver connectionStringResolver;

        public SqlCharacterSaver(IConnectionStringResolver connectionStringResolver)
        {
            this.connectionStringResolver = connectionStringResolver;
        }

        public async Task Save(Character character, Guid creatorId)
        {
            using (var connection = new SqlConnection(await connectionStringResolver.ResolveConnectionString("DefaultConnectionString")))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("Character.AddCharacter", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", Guid.NewGuid());
                    command.Parameters.AddWithValue("@CreatorId", creatorId);
                    command.Parameters.AddWithValue("@Blob", JsonConvert.SerializeObject(character));

                    await command.ExecuteNonQueryAsync();
                }

            }
        }
    }
}
