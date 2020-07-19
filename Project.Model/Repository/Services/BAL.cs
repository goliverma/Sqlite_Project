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
            string query = "select * from employee";
            return data.LoadData<Employee, dynamic>(query, new {});
        }

        public Task Insert(Employee employee)
        {
            string query = @"insert into employee (Name, Email, Address) values (@Name, @Email, @Address)";
            return data.SaveData<Employee>(query, employee);
        }
    }
}