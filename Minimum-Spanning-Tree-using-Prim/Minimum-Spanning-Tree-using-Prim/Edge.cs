using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Tree_using_Prim
{
    public class Edge
    {
        Node node1, node2;
        private int weight;
        private bool isUsed = false;

        public Edge(Node node1, Node node2, int weight)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.weight = weight;
        }

        public int getWeight()
        {
            return weight;
        }

        public void setNodesVisited()
        {
            node1.setVisited(true);
            node2.setVisited(true);
        }

        public bool areNodesVisited()
        {
            return (node1.isVisited() & node2.isVisited());
        }

        public void setUsed()
        {
            isUsed = true;
            setNodesVisited();
        }

        public bool IsUsed()
        {
            return isUsed;
        }

        public static Edge getMinEdge(HashSet<Edge> edges)
        {
            Edge edge = null, tempEdge = null;
            int minWeight = int.MaxValue;
            Object[] temp = edges.ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                tempEdge = (Edge)temp[i];
                if ((tempEdge.getWeight() < minWeight)
                        && !tempEdge.areNodesVisited() && !tempEdge.IsUsed())
                {
                    minWeight = tempEdge.getWeight();
                    edge = tempEdge;
                }
            }
            return edge;
        }

    }
}
