using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


namespace c_
{
    public class OOP1
    {
        static int highScore = 150;
        static string highScorePlayerName = "Joe";
        static void Main()
        {
            System.Console.WriteLine("Enter the player score and state a name:");
            int score = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            Player(score, name);
            Console.ReadKey();

        }

        public static void Player(int score, string name)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayerName = name;
                System.Console.WriteLine($"New highscore is {highScore}");
                System.Console.WriteLine($"New highscore holder is {highScorePlayerName}");
            }
            else
            {
                System.Console.WriteLine
                (@$"The old highscore of {highScore}could not be broken {Environment.NewLine}and is still held by {highScorePlayerName}");
            }
        }
    }
}