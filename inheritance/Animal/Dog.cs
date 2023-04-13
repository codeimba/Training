using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Wuf, wuf");
        }

        public override void Playing()
        {
            if (IsHappy)
            {
                base.Playing();
            }
            else if (IsHappy == false && IsHungry)
            {
                System.Console.WriteLine($"{Name} is not happy! You might wanna feed it!");
            }
            else
            {
                System.Console.WriteLine($"Its just a gloomy day for the {Name}");
            }
        }
    }
}