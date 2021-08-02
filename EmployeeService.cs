using ODataApp.Models;
using System.Collections.Generic;

namespace ODataApp
{
    public class EmployeeService
    {
        public List<Employee> InitialData()
        {
            List<Employee> list = new();
            list.Add(new Employee(1, "Herman", "Software Engineer", "Singapore"));
            list.Add(new Employee(2, "Jhon", "Front End", "Singapore"));
            list.Add(new Employee(3, "David", "Back End", "Singapore"));
            list.Add(new Employee(4, "Joe", "Team Lead", "Singapore"));

            return list;
        }

        public List<Employee> GetEmployees() => InitialData();
    }
}
