using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dto.Employees;
using Service.Employees;

namespace web.Controllers
{
    public class EmployeeExampleController : Controller
    {
        private readonly IRetrieveEmployeesQuery retrieveEmployeesQuery;

        public static List<EmployeeDto> Employees = new List<EmployeeDto>
        {
            new EmployeeDto {Id = 1, FirstName = "Adam", LastName = "Alinauskas"},
            new EmployeeDto {Id = 2, FirstName = "Bruce", LastName = "Banner"},
            new EmployeeDto {Id = 3, FirstName = "Peter", LastName = "Parker"},
            new EmployeeDto {Id = 4, FirstName = "Silver", LastName = "Surfer"},
            new EmployeeDto {Id = 5, FirstName = "Stephen", LastName = "Strange"},
            new EmployeeDto {Id = 6, FirstName = "Pepper", LastName = "Potts"}
        };

        public EmployeeExampleController(IRetrieveEmployeesQuery retrieveEmployeesQuery)
        {
            this.retrieveEmployeesQuery = retrieveEmployeesQuery;
        }

        // GET: EmployeeExample
        public ActionResult Index()
        {
            if (retrieveEmployeesQuery == null)
                throw new OutOfMemoryException();

            return View();
        }

        public ActionResult getEmployees()
        {
            return Json(new EmployeeListingDto{Items = Employees}, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Create(EmployeeDto dto)
        {
            Employees.Add(dto);
            return Json(null);
        }

        public ActionResult Edit(long Id)
        {
            return Json(Employees.SingleOrDefault(x => x.Id == Id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeDto dto)
        {
            var employee = Employees.SingleOrDefault(x => x.Id == dto.Id);
            if (employee != null)
            {
                employee.FirstName = dto.FirstName;
                employee.LastName = dto.LastName;
            }

            return Json(null);
        }
    }
}