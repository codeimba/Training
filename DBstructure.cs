using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class DBstructure
    {
        public List<Employee> EmployeesTable()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("CEO", "", 0, 0));
            employees.Add(new Employee("Guard", "Mattias", 45, 200));
            employees.Add(new Employee("Warchief", "Garosh", 55, 450));
            employees.Add(new Employee("King", "Anduin", 24, 1400));
            employees.Add(new Employee("Commander", "Etrigg", 67, 300));
            employees.Add(new Employee("Pristess of the Moon", "Tyrande", 890, 900));

            return employees;
        }
    }
}