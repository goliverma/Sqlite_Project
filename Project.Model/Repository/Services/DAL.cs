using System.Linq;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Project.Model.Repository.Interface;

namespace Project.Model.Repository.Services
{
    public class DAL : IDAL
    {
        private readonly IConfiguration config;
        private string ConnectionStringName { get; set; } = "Default";

        public DAL(IConfiguration config)
        {
            this.config = config;
        }
        public async Task<IEnumerable<T>> LoadData<T, U>(string query, U parameter)
        {
            string connectionstring = config.GetConnectionString(ConnectionStringName);
            using (var connection = new SQLiteConnection(connectionstring))
            {
                var data = await connection.QueryAsync<T>(query, parameter);
                return data.ToList();
            } 
        }

        public async Task SaveData<T>(string query, T parameter)
        {
            string connectionstring = config.GetConnectionString(ConnectionStringName);
            using (var connection = new SQLiteConnection(connectionstring))
            {
                await connection.ExecuteAsync(query, parameter);
            } 
        }
    }
}