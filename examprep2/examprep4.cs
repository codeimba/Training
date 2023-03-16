using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            string gameName = string.Empty;
            int soldGames = int.Parse(Console.ReadLine());

            double heartstoneCount = 0;
            double fortniteCount = 0;
            double overwatchCount = 0;
            double othersCount = 0;

            for (int i = 0; i < soldGames; i++)
            {
                gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    heartstoneCount++;
                }
                else if (gameName == "Fornite")
                {
                    fortniteCount++;
                }
                else if (gameName == "Overwatch")
                {
                    overwatchCount++;
                }
                else
                {
                    othersCount++;
                }
            }
            double HearthstonePercent = 100.00 * (heartstoneCount / soldGames);
            double fornitePercent = 100.00 * (fortniteCount / soldGames);
            double overwatchPercent = 100.00 * (overwatchCount / soldGames);
            double otherGamesPercent = 100.00 * (othersCount / soldGames);

            System.Console.WriteLine($"Hearthstone - {HearthstonePercent:f2}%");
            System.Console.WriteLine($"Fornite - {fornitePercent:f2}%");
            System.Console.WriteLine($"Overwatch - {overwatchPercent:f2}%");
            System.Console.WriteLine($"Others - {otherGamesPercent:f2}%");
        }
    }
}