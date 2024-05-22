using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEngineHirechy
{
    public class TileMap
    {
        public void Board()
        {
            // Define the size of the chessboard
            int boardSize = 8;

            // Column labels (numbers)
            Console.Write("  ");
            for (int col = 0; col < boardSize; col++)
            {
                //Console.Write($" {col + 1}");
            }
            Console.WriteLine();

            // Iterate through each row
            for (int row = -1; row < boardSize + 1; row++)
            {
                // Print the row labels
                if (row >= 0 && row < boardSize)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("  ");
                }

                // Iterate through each column in the current row
                for (int col = -1; col < boardSize + 1; col++)
                {
                    if (col == -1 || col == boardSize)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($" {row + 1}");
                    }

                    else if (row == -1 || row == boardSize)
                    {
                        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write($" {alphabet[7]}");
                    }

                    else
                    {
                        // Determine the color based on the position
                        if ((row + col) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                        }

                        // Print the current cell with a space to separate columns
                        Console.Write("  "); // Two spaces to form a square-like cell
                    }
                }

                // Reset the background color and move to the next line after each row
                Console.ResetColor();
                Console.WriteLine();
            }

            // Reset the color to default
            Console.ResetColor();
        }
    }
}
