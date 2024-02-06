using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Lecture217
{
    internal class Game
    {



/**
 * Don't let the machines win. You are humanity's last hope...
 **/

        public static void MainGame()
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            char[,] grid = new char[height, width];
            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .
                for (int j = 0; j < width; j++)
                {
                    grid[i, j] = line[j];
                }
            }


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    string outstr = "";
                    if (grid[i, j] == '0')
                    {
                        outstr = $"{j} {i}";

                        (int, int) right = CheckRight(i, j, grid, height, width);
                        outstr = outstr + $" {right.Item1} {right.Item2}";

                        (int, int) down = CheckDown(i, j, grid, height, width);
                        outstr = outstr + $" {down.Item1} {down.Item2}";

                        Console.WriteLine(outstr);
                    }
                    else
                    {
                        continue;
                    }
                }
            }


            static (int, int) CheckRight(int i, int j, char[,] grid, int height, int width)
            {
                if (j + 1 < width)
                {
                    for (int x = j+1; x < width; x++)
                    {
                        if (grid[i, x] == '0')
                        {
                            return (x, i);
                        }
                    }
                }
                return (-1, -1);
            }

            static (int, int) CheckDown(int i, int j, char[,] grid, int height, int width)
            {
                if (i + 1 < height)
                {
                    for (int y = i+1; y < height; y++)
                    {
                        if (grid[y, j] == '0')
                        {
                            return (j, y);
                        }
                    }
                }
                return (-1, -1);
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // Three coordinates: a node, its right neighbor, its bottom neighbor
            // Console.WriteLine("0 0 1 0 0 1");
            // Console.WriteLine("1 0 -1 -1 -1 -1");
            // Console.WriteLine("0 1 -1 -1 -1 -1");

        }

    }

}
