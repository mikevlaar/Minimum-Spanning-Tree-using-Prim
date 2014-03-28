using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Tree_using_Prim
{
    public class Node
    {
        private int nodeId;
        private bool visited;
        private HashSet<Edge> edges;

        public Node(int nodeId)
        {
            this.nodeId = nodeId;
            this.visited = false;
            edges = new HashSet<Edge>();
        }

        public int getNodeId()
        {
            return nodeId;
        }

        public bool isVisited()
        {
            return visited;
        }

        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        public HashSet<Edge> getEdges()
        {
            return edges;
        }

        public void addEdge(Edge edge)
        {
            edges.Add(edge);
        }
    }
}
