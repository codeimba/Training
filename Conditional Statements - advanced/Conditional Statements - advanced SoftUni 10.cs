using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (!(number >= 100 && number <= 200))
        {
            if (!(number == 0))
                Console.WriteLine("invalid");
        }
    }
}