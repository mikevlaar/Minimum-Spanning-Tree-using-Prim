using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Tree_using_Prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[][] matrix = new int[10][];
 
            for (int i = 0; i < matrix.Length; i++) {
                 matrix[i] = new int[i + 1];
             }
 
            for (int i = 0; i < matrix.Length; i++) {
                 for (int j = 0; j < i; j++) {
                     matrix[i][j] = (int) (random.Next(0, 100));
                 }
             }
 
            Console.WriteLine("Graph is >>");
             for (int i = 0; i < matrix.Length; i++) {
                 for (int j = 0; j < i; j++) {
                     Console.Write(matrix[i][j] + ",");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();

             Graph graph = new Graph(matrix);
             Console.WriteLine("The Total Cost is : " + graph.performPrim(0));
             Console.ReadLine();
        }
    }
}
