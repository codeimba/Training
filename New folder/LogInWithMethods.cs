using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


namespace c_
{
    public class OOP1
    {
        static string username;
        static string password;
        static void Main()
        {
            Register();
            LogIn();
            Console.ReadKey();

        }
        public static void Register()
        {
            System.Console.WriteLine("Enter prefered username,followed by a password:");
            username = Console.ReadLine();
            password = Console.ReadLine();
            System.Console.WriteLine("Registration complete");
            System.Console.WriteLine("-----------------------");
        }
        public static void LogIn()
        {
            System.Console.WriteLine("Enter your username and password to login:");
            if (username == Console.ReadLine())
            {
                if (password == Console.ReadLine())
                {
                    System.Console.WriteLine("Login successful");
                    System.Console.WriteLine("===================");
                    
                }
                else
                {
                    System.Console.WriteLine("Login failed! Wrong password , restarting program...");
                }
            }
            else
            {
                System.Console.WriteLine("Login failed! Wrong username , restarting program...");
            }
        }
    }
}