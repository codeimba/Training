using System;

public class Program
{
    public static void Main()
    {
        string correctPassword = "s3cr3t!P@ssw0rd";
        string userPassword = Console.ReadLine();
        if (correctPassword != userPassword)
        {
            Console.WriteLine("Wrong password!");
        }
        else
        {
            Console.WriteLine("Welcome");
        }
    }
}