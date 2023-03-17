using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            int spicesNumber = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCount = 0;
            const int DAYLY_DECRESE = 10;
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int CONSUMED_BY_WORKERS = 26;
            while (spicesNumber >= 100)
            {
                totalConsumed += spicesNumber - CONSUMED_BY_WORKERS;
                spicesNumber -= DAYLY_DECRESE;
                daysCount++;
                if (spicesNumber < MINIMUM_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }
            System.Console.WriteLine(daysCount);
            System.Console.WriteLine(totalConsumed);
        }
    }
}