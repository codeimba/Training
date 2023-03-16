using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            double cargoSize = double.Parse(Console.ReadLine());
            int numSuitCase = 0;
            string input = string.Empty;
            int numCase = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                double suiteCaseSize = double.Parse(input);
                numCase++;
                if (numCase % 3 == 0)
                {
                    suiteCaseSize = suiteCaseSize + (suiteCaseSize * 0.10);
                }
                if (suiteCaseSize >= cargoSize)
                {
                    System.Console.WriteLine("No more space!");
                    break;
                }
                numSuitCase++;
                cargoSize -= suiteCaseSize;
            }
            if (input == "End")
            {
                System.Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            System.Console.WriteLine($"Statistic: {numSuitCase} suitcases loaded.");
        }
    }
}