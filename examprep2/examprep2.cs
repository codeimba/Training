using System;

namespace c_.examprep
{
    public class Examprep2
    {
        public static void Main(string[] args)
        {
            int draws = 0;
            int wins = 0;
            int lost = 0;
            string matchResult = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                matchResult = Console.ReadLine();

                int firstTeamScore = matchResult[0];
                int secondTeamScore = matchResult[2];

                if (firstTeamScore == secondTeamScore)
                {
                    draws++;
                }
                else if (firstTeamScore > secondTeamScore)
                {
                    wins++;
                }
                else
                {
                    lost++;
                }
            }
            System.Console.WriteLine("Team won {0} games.", wins);
            System.Console.WriteLine("Team lost {0} games.", lost);
            System.Console.WriteLine("Drawn games: {0}", draws);

        }
    }
}