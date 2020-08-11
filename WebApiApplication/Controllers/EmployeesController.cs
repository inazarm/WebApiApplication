using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeesDataAccess;


namespace WebApiApplication.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (employeeDBEntities db=new employeeDBEntities())
            {
                return db.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (employeeDBEntities db = new employeeDBEntities())
            {
                return db.Employees.FirstOrDefault(e=>e.Id==id);
            }
        }


    }
}
