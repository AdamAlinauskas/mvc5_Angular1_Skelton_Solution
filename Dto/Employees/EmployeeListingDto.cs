using System.Collections.Generic;

namespace Dto.Employees
{
    public class EmployeeListingDto
    {
        public List<EmployeeDto> Items { get; set; } = new List<EmployeeDto>();
    }
}
