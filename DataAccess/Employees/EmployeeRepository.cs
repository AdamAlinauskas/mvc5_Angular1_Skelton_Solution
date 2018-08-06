using System.Collections.Generic;
using Dto.Employees;

namespace DataAccess.Employees
{
    public interface IEmployeeRepository
    {
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<EmployeeDto> Employees = new List<EmployeeDto>
        {
            new EmployeeDto {Id = 1, FirstName = "Adam", LastName = "Alinauskas"},
            new EmployeeDto {Id = 2, FirstName = "Bruce", LastName = "Banner"},
            new EmployeeDto {Id = 3, FirstName = "Peter", LastName = "Parker"},
            new EmployeeDto {Id = 4, FirstName = "Silver", LastName = "Surfer"},
            new EmployeeDto {Id = 5, FirstName = "Stephen", LastName = "Strange"},
            new EmployeeDto {Id = 6, FirstName = "Pepper", LastName = "Potts"}
        };
    }
}