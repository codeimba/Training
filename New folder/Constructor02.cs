using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class PhoneOne
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public PhoneOne()
        {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }

        public PhoneOne(string company, string model)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = "unknown";
        }
        public PhoneOne(string company, string model, string releaseDay)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = releaseDay;
        }
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }
    }
}