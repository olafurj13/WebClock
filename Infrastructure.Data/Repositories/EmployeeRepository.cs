using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IContextProvider contextProvider;
        
        public EmployeeRepository(IContextProvider contextProvider)
        {
            this.contextProvider = contextProvider;
        }
        public int AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var context = contextProvider.GetDatabaseContext();

            var employees = context.Employees.Select(x => x).ToList();

            return employees;
        }

    }
}
