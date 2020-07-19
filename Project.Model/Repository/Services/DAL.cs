using System.Collections.Generic;
using System.Threading.Tasks;
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
        public Task<IEnumerable<T>> LoadData<T, U>(string query, U parameter)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveData<T>(string query, T parameter)
        {
            throw new System.NotImplementedException();
        }
    }
}