using System;

namespace Mod2_ChessBoard2
{
    class Program
    {
        static void Main(string[] args)
        {
            // For this assignment, you will create the pattern of a chess board that is 8 x 8.
            // Use X and O to represent the squares.

            // Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.

            // Include a decision structure to ensure that alternate rows start with opposite characters as a real chess board alternates the colors among rows.

            bool xrow = true;
            int width = 8;
            int rows = 8;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < (width - 1); j++)
                {
                    if (xrow == true)
                        {
                            Console.Write("X");
                            xrow = false;
                        }
                    else
                        {
                            Console.Write("Y");
                            xrow = true;
                        }
                }
                if (xrow == true)
                {
                    Console.WriteLine("X");
                    xrow = true;
                }
                else
                {
                    Console.WriteLine("Y");
                    xrow = false;
                }

            }

        }
    }
}
