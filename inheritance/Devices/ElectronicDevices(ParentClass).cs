using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class ElectronicDevices
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectronicDevices(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}