using System.Numerics;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Linq;


namespace c_
{
    public class OOP1
    {
        static void Main()
        {
           
        }
        public static bool Checker(string[,] board)
        {
            for (int a = 0; a < 3; a++)
            {
                if (board[a, 0] == board[a, 1] && board[a, 1] == board[a, 2])
                    return true;
                if (board[0, a] == board[1, a] && board[1, a] == board[2, a])
                    return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }
    }
}