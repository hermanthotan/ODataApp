using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataApp.Controllers
{
    public class EmployeesController : ODataController
    {
        private readonly EmployeeService employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [EnableQuery]
        public IActionResult Get() => Ok(employeeService.GetEmployees());

        [EnableQuery]
        public IActionResult Get(int key) => Ok(employeeService.GetEmployees().FirstOrDefault(x => x.Id == key));

        //https://localhost:44322/odata/$metadata
        //https://localhost:44322/odata/employees
        //https://localhost:44322/odata/Employees(2)
        //https://localhost:44322/odata/Employees?$select=id,fullName
    }
}
