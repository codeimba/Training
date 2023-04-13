using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class TV : ElectronicDevices
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void WatchingTV()
        {
            if (IsOn)
            {
                System.Console.WriteLine("You are watching tv!");
            }
            else
            {
                System.Console.WriteLine("The TV is switch off, turn it on first!");
            }
        }
    }
}