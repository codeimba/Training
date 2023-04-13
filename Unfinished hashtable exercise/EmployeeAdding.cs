using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class EmployeeAdding
    {

        public Dictionary<string, Employee> AddingToDict()
        {
            var employees = new DBstructure().EmployeesTable();

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee item in employees)
            {
                employeeDirectory.Add(item.Role, item);
                System.Console.WriteLine($"{item.Name} working as {item.Role} and is {item.Age} years old,having a rate of: {item.Rate}");
            }
            return employeeDirectory;
        }

    }
}