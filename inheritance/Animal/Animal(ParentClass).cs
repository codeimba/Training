using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            IsHungry = true;
        }

        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                System.Console.WriteLine($"{Name} is eating.Please let it finish!");
            }
            else
            {
                System.Console.WriteLine($"{Name} is not hungry right know.Check again later!");
            }
        }

        public virtual void Playing()
        {
            System.Console.WriteLine($"{Name} is playing with you!");
        }
    }
}