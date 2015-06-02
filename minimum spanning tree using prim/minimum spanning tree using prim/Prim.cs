using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_spanning_tree_using_prim
{
    class Prim
    {
        private int vertices = 5;
        private int[] parent;
        private int[] key;
        private bool[] mstSet;

        public Prim(int vertices)
        {
            this.vertices = vertices;
            parent = new int[vertices];
            key = new int[vertices];
            mstSet = new bool[vertices];
        }

        /**
         * A utility function to find the vertex with minimum key value, 
         * from the set of vertices not yet included in MST
         * @param key :The list of smallest weights found in the MST.
         * @param mstSet :The MST represented by booleans.
         */
        private int minKey(int[] key, bool[] mstSet)
        {
            int min = int.MaxValue;
            int min_index = 0;
 
            for (int v = 0; v < vertices; v++)
            {
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v]; 
                    min_index = v;
                }
            }
 
            return min_index;
        }

        /** A utility function to print the constructed MST stored in parent[]
         * @param parent :The parent of a vertice. Used to show the way that was traveled.
         * @param graph :The adjacency matrix of the MST.
         */
        private void printMST(int[] parent, int[][] graph)
        {
            //Hier komt een conflict.
            Console.WriteLine("\nEdge   Weight\n");
            for (int i = 1; i < vertices; i++)
            {
                Console.WriteLine(parent[i] + " - "+ i + " |  " + graph[i][parent[i]] + "\n");
            }
            //plus wat extra's
        }

        /** Function to construct and print MST for a graph represented using adjacency matrix representation.
         * @param graph :The adjacency matrix of the MST.
         */
        public void primMST(int[][] graph)
        {
            initializePrimKeys();

            for (int count = 0; count < vertices; count++)
            {
                int u = minKey(key, mstSet);
                mstSet[u] = true;
 
                for (int v = 0; v < vertices; v++)
                {
                    if (graph[u][v] != 0 && mstSet[v] == false && graph[u][v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u][v];
                    }
                }
            }
            printMST(parent, graph);
        }

        /** Function to initialize the key array and mstSet.
         */
        private void initializePrimKeys()
        {
            for (int i = 0; i < vertices; i++)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;
        }
    }
}
