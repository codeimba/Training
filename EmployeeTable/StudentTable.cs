using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.EmployeeTable
{
    public class StudentTable
    {
        public List<Student> ListOfStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Varian", 78));
            students.Add(new Student(2, "Sylvanas", 99));
            students.Add(new Student(3, "Valeera", 87));
            students.Add(new Student(4, "Tyrdande", 97));
            students.Add(new Student(5, "Malfurien", 100));
            students.Add(new Student(5, "Grigor", 51));

            return students;
        }
    }
}