using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Model.Data;
using Project.Model.Repository.Interface;

namespace Project.Model.Repository.Services
{
    public class BAL : IBAL
    {
        public IDAL data { get; }
        public BAL(IDAL data)
        {
            this.data = data;
        }
        public Task<IEnumerable<Employee>> GetAllEmployee()
        {
            throw new System.NotImplementedException();
        }

        public Task Insert(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}