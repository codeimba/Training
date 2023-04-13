using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace c_
{
    public class EmployeeMain
    {
        public static void Main(string[] args)
        {

            Dictionary<string, Employee> empl = new EmployeeAdding().AddingToDict();

            bool updated = false;
            for (int i = 0; i < empl.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = empl.ElementAt(i);
                Employee value = keyValuePair.Value;
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine($"Employee Name: {value.Name}");
                System.Console.WriteLine($"Employee Age: {value.Age}");
                System.Console.WriteLine($"Employee Role: {value.Role}");
                System.Console.WriteLine($"Employee Salary: {value.Salary}");
                System.Console.WriteLine("============================");
                string keyToUpdate = "CEO";
                for (var a = 0; a < empl.Count; a++)
                {
                    if (empl.ContainsKey(keyToUpdate))
                    {
                        System.Console.WriteLine("+++++++++++++++++++++++++++++++");
                        System.Console.WriteLine($"Updated employee with role:{keyToUpdate}");
                        System.Console.WriteLine("+++++++++++++++++++++++++++++++");
                        empl[keyToUpdate] = new Employee("CEO", "Tyrande", 999, 890);
                        KeyValuePair<string, Employee> keyValuePair2 = empl.ElementAt(a);
                        Employee value1 = keyValuePair.Value;
                        System.Console.WriteLine("_________________________________");
                        System.Console.WriteLine($"New employee name:{value1.Name}");
                        System.Console.WriteLine($"New employee Age: {value1.Age}");
                        System.Console.WriteLine($"New employee Role: {value1.Role}");
                        System.Console.WriteLine($"NEw employee Salary: {value1.Salary}");
                        System.Console.WriteLine("_________________________________");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine($"No employee with found with key/role:{keyToUpdate}");
                    }
                }
                foreach (var item in empl)
                {
                    if(item.Key == "CEO")
                    {
                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}