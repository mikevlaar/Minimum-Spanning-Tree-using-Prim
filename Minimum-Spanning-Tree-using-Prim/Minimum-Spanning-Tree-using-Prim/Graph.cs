using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Spanning_Tree_using_Prim
{
    public class Graph {
    int[][] adjMatrix;
    public Edge[] edges;
    Node[] nodes;
 
    public Graph(int[][] adjMatrix) {
         this.adjMatrix = adjMatrix;
         this.createGraph();
     }
 
    public void createGraph() {
        int adjMatrixLength = this.adjMatrix.Length;
         int length = adjMatrixLength * (adjMatrixLength - 1) / 2;
         edges = new Edge[length];
         length = this.adjMatrix.Length;
         nodes = new Node[length];
         for (int i = 0; i < nodes.Length; i++) {
             nodes[i] = new Node(100 + i);
         }
         int counter = 0;
         for (int i = 0; i < this.adjMatrix.Length; i++) {
             for (int j = 0; j < i; j++) {
                 edges[counter] = new Edge(nodes[i], nodes[j], adjMatrix[i][j]);
                 nodes[i].addEdge(edges[counter]);
                 nodes[j].addEdge(edges[counter]);
                 counter++;
             }
         }
     }
 
    public int performPrim(int startPoint) {
         HashSet<Edge> mstEdge = new HashSet<Edge>();
         nodes[startPoint].setVisited(true);
         do {
             HashSet<Node> visitedNodes = this.getVisitedNodes();
             Object[] vnodes = visitedNodes.ToArray();
             HashSet<Edge> edgeList=new HashSet<Edge>();
             for(int i=0;i<vnodes.Length;i++) {
                 Object []egs=((Node)vnodes[i]).getEdges().ToArray();
                 for(int j=0;j<egs.Length;j++) {
                     if(!((Edge)egs[j]).IsUsed()) {
                         edgeList.Add((Edge)egs[j]);
                     }
                 }
             }
             try {
                 Edge temp=Edge.getMinEdge(edgeList);
                 temp.setUsed();
                 mstEdge.Add(temp);
             } catch (Exception e) {
             }
         } while (isGraphVisited());
         Object []finalEdges=mstEdge.ToArray();
         int totalCost=0;
         for(int i=0;i<finalEdges.Length;i++)
         {
             totalCost+=((Edge)finalEdges[i]).getWeight();
         }
         return totalCost;
     }
 
    public HashSet<Node> getVisitedNodes() {
         HashSet<Node> visitedNodes = new HashSet<Node>();
         for (int i = 0; i < nodes.Length; i++) {
             if (nodes[i].isVisited()) {
                 visitedNodes.Add(nodes[i]);
             }
         }
         return visitedNodes;
     }
 
    public bool isGraphVisited() {
         for (int i = 0; i < nodes.Length; i++) {
             if (!nodes[i].isVisited()) {
                 return true;
             }
         }
         return false;
     }
 
}
}
