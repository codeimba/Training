using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Radio : ElectronicDevices
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                System.Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                System.Console.WriteLine("Radio is switche off, switch it on first.");
            }
        }
    }
}