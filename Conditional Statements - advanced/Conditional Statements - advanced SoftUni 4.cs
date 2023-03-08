using System;

public class Program
{
    public static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (age >= 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else // f
            {
                Console.WriteLine("Ms.");
            }
        }
        else
        {
            if (gender == "m")
            {
                Console.WriteLine("Master");
            }
            else // f
            {
                Console.WriteLine("Miss");
            }
        }
    }
}