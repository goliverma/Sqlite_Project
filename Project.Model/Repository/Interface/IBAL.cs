using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Model.Data;

namespace Project.Model.Repository.Interface
{
    public interface IBAL
    {
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task Insert(Employee employee);
    }
}