using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int myId, string myName, float myGPA)
        {
            this.ID = myId;
            this.Name = myName;
            this.GPA = myGPA;
        }
    }
}