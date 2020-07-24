using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Model.Data;

namespace Project.Model.Repository.Interface
{
    public interface IBAL
    {
        Task<IEnumerable<Employee>> GetAllEmployee();
        Task<Employee> GetById(int id);
        Task Insert(Employee employee);
        Task<Employee> UpdateEmployee(Employee changeemployee);
        Task DeleteEmployee(int id);
    }
}