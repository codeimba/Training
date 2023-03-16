using System;

namespace c_.examprep
{
    public class Exam
    {
        public static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());
            double moneyWonForTheDay = 0;
            double allMoneyFromDays = 0;
            int wonGames = 0;
            int lostGames = 0;
            double totalMoneyWon = 0;
            int daysLost = 0;
            int daysWon = 0;

            for (int i = 0; i < daysOfTournament; i++)
            {
                wonGames = 0;
                lostGames = 0;
                moneyWonForTheDay = 0;
                string input = string.Empty;
                while ((input = Console.ReadLine()) != "Finish")
                {
                    string statusOfGame = Console.ReadLine();
                    if (statusOfGame == "win")
                    {
                        moneyWonForTheDay += 20;
                        wonGames++;
                    }
                    else if (statusOfGame == "lose")
                    {
                        lostGames++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (lostGames > wonGames)
                {
                    daysLost++;
                }
                else
                {
                    daysWon++;
                    moneyWonForTheDay = moneyWonForTheDay + ((moneyWonForTheDay * 10 / 100));
                }
                allMoneyFromDays += moneyWonForTheDay;
            }
            totalMoneyWon = allMoneyFromDays;
            if (daysWon > daysLost)
            {
                totalMoneyWon = totalMoneyWon + ((totalMoneyWon * 20) / 100);
                System.Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyWon:f2}");
            }
            else
            {
                System.Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyWon:f2}");
            }
        }
    }
}