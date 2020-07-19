using System.Collections.Generic;
using System.Threading.Tasks;
namespace Project.Model.Repository.Interface
{
    public interface IDAL
    {
        Task<IEnumerable<T>> LoadData<T, U>(string query, U parameter);
        Task SaveData<T>(string query, T parameter);
    }
}