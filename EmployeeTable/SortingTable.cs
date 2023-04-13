using System.Reflection.Emit;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace c_.EmployeeTable
{
    public class SortingTable
    {
        public Hashtable GetTableWithLogs()
        {
            var students = new StudentTable().ListOfStudents();
            Hashtable studentsTable = new Hashtable();
            foreach (Student item in students)
            {

                if (!(studentsTable.ContainsKey(item.ID)))
                {
                    studentsTable.Add(item.ID, $"{item.Name} and {item.GPA}");
                    System.Console.WriteLine($"Student with ID:{item.ID} was added!");
                }
                else
                {
                    System.Console.WriteLine($"Sorry, A student with the same ID:{item.ID}, already exists.");
                }
            }
            return studentsTable;
        }
    }
}