using System;

namespace Mod2_ChessBoard
{
    class Program
    {
        static void Main()
        {

            // Create the pattern of a chess board that is 8 x 8. 
            // Use X and O to represent the squares.

            int x = 0;

            while (x < 4)
            {
                Console.WriteLine("XOXOXOXO");
                Console.WriteLine("OXOXOXOX");
                x++;
            }
        }
    }
}
