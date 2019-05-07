using System;
/*
 * 1. 2D grid
 * 2. Cell is dead or al;ive
 * 3. when we generate new sate
 * 3a cell is alive neighbours = 0,1 = dead
 * 3b cell is alive neighbours= 2,3 = alive
 * 3c cell is alive neighboues >3 = dead
 * 3d cell is dead neighbours ==3 = alive
*/
namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)

        {
            bool[,] grid = new bool[10, 10];
            for (int y = 0; y <10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(grid[x, y]);

                }
                Console.WriteLine();

            }
        }
    }
}