using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeAccessData;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmpDBEntities entities = new EmpDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employee Get(int id)
        {
            using (EmpDBEntities entities = new EmpDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}

