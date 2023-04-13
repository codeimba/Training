using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


namespace c_
{
    public class OOP1
    {
        static void Main()
        {
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[6];
            students[0] = new Student(1, "Varian", 78);
            students[1] = new Student(2, "Sylvanas", 99);
            students[2] = new Student(3, "Valeera", 87);
            students[3] = new Student(4, "Tyrdande", 97);
            students[4] = new Student(5, "Malfurien", 100);
            students[5] = new Student(5, "Grigor", 51);

            foreach (Student item in students)
            {
                if (!(studentsTable.ContainsKey(item.ID)))
                {
                    studentsTable.Add(item.ID, item);
                    System.Console.WriteLine($"Student with ID:{item.ID} was added!");
                }
                else
                {
                    System.Console.WriteLine($"Sorry, A student with the same ID:{item.ID}, already exists.");
                }
            }
            foreach (DictionaryEntry item in studentsTable)
            {
                System.Console.WriteLine(item.Value.ToString());
            }
            Console.ReadKey();
        }
    }
}