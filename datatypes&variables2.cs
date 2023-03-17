using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countOfPokedTargets = 0;
            int startingPower = power;

            while(power >= distance)
            {
                power -= distance;
                countOfPokedTargets++;
                if(startingPower * 0.5 == power && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
            }
            System.Console.WriteLine(power);
            System.Console.WriteLine(countOfPokedTargets);
        }
    }
}