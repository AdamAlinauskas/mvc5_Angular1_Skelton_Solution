using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Employees;
using Dto.Employees;

namespace Service.Employees
{
    public interface IRetrieveEmployeesQuery
    {
        IEnumerable<EmployeeDto> Fetch();
    }

    public class RetrieveEmployeesQuery : IRetrieveEmployeesQuery
    {
        public RetrieveEmployeesQuery(IEmployeeRepository employeeRepository)
        {
        }

        public IEnumerable<EmployeeDto> Fetch()
        {
            return new List<EmployeeDto>();
        }
    }
}
