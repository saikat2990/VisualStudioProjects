using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.netMvcTuitorial.Models;

namespace Asp.netMvcTuitorial.Controllers
{
    public class EmployeeDataController : Controller
    {
        // GET: EmployeeData
        public ActionResult Details(int id)
        {
            EmployeeDataContext employeeDataContext = new EmployeeDataContext();

            EmployeeData employeeData= employeeDataContext.EmployeeDatas.Single(emp => emp.EmployeeID == id);

            //EmployeeData employeeData = new EmployeeData() {
            //    EmployeeID = 1,
            //    Name = "saikat",
            //    Salary = 10000,
            //    Email = "saikat2990@gmail.com",
            //    PhnNumber = "0152125690"
            //};

            return View(employeeData);
        }
    }
}