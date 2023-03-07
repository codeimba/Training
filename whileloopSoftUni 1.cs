using System;

namespace c_
{
    public class Tasks
    {
        static void Main()
        {
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                System.Console.WriteLine(command);
                command = Console.ReadLine();
            }
        }
    }
}