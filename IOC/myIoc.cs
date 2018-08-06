using DataAccess.Employees;
using Service.Employees;
using StructureMap;

namespace IOC
{
    public static class MyIoc
    {
        public static void Init(IContainer container)
        {
            container.Configure(x => { x.For<IRetrieveEmployeesQuery>().Use<RetrieveEmployeesQuery>(); });
            container.Configure(x => { x.For<IEmployeeRepository>().Use<EmployeeRepository>(); });
        }
    }
}
