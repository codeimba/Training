using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get // 8 hours , 5 days , 4 weeks , 12 moths
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}