using System;
using System.Numerics;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            int snowBows = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            int snowBallQuality = 0;
            BigInteger bestSnowBall = int.MinValue;
            string bestFormula = string.Empty;

            for (int i = 0; i < snowBows; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger value = snowBallSnow / snowBallTime;

                snowBallValue = BigInteger.Pow(value, snowBallQuality);
                if (snowBallValue > bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestFormula = $"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuality})";
                }

            }
            System.Console.WriteLine($"{bestFormula}");
        }
    }
}