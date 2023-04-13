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
            PhoneOne samsung = new PhoneOne();
            PhoneOne xiaomi = new PhoneOne("Xioami","MiMix2");
            PhoneOne nokia = new PhoneOne("Nokia", "Lumia", "01.01.2014");
            nokia.Introduce();
            samsung.Introduce();
            xiaomi.Introduce();
            Console.ReadKey();
        }
    }
}