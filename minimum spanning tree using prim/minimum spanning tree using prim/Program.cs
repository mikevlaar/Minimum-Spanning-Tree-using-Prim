using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_spanning_tree_using_prim
{
    class Program
    {
        private int[][] adjacency_matrix = {    
                                    new int[5] {0, 2, 0, 6, 0},
                                    new int[5] {2, 0, 3, 8, 5},
                                    new int[5] {0, 3, 0, 0, 7},
                                    new int[5] {6, 8, 0, 0, 9},
                                    new int[5] {0, 5, 7, 9, 0},
                                };

        public int[][] Adjacency_matrix
        {
            get { return adjacency_matrix; }
            set { adjacency_matrix = value; }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.startPrim();
        }

        public void startPrim()
        {
            Console.WriteLine("The following graph is created\n");
            Console.WriteLine("    2    3");
            Console.WriteLine("(0)--(1)--(2)");
            Console.WriteLine(" |   / \\   |");
            Console.WriteLine("6| 8/   \\5 |7");
            Console.WriteLine(" | /     \\ |");
            Console.WriteLine("(3)-------(4)");
            Console.WriteLine("      9       ");
            Console.WriteLine("\nThe Adjacency Matrix for the graph is as follows:");
            displayGrid(Adjacency_matrix);

            Prim prim = new Prim(Adjacency_matrix.Length);
            prim.primMST(Adjacency_matrix);

            Console.ReadLine();
        }

        /**
        * Displays the grid.
        * @param grid the array that contains the row to be checked
        */
        public void displayGrid(int[][] grid)
        {
            for (int r = 0; r < grid.Length; r++)
            {
                Console.WriteLine("+-+-+-+-+-+");
                for (int c = 0; c < grid[r].Length; c++)
                {
                    Console.Write("|");
                    displayDigits(r, c, grid);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("+-+-+-+-+-+");
        }

        /**
        * Displays the digit inside the grid.
        * @param grid the array that contains the row to be checked
        * @param row the row to check for the number
        * @param column the column to check for the number
        */
        private void displayDigits(int row, int column, int[][] grid)
        {
            if (grid[row][column] == 0)
            {
                Console.Write('0');
            }
            else
            {
                Console.Write(grid[row][column]);
            }
        }
    }
}
