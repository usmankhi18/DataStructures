using System;
using System.Collections.Generic;

namespace DataStructures.Graph
{
    public class GraphManager
    {
        private readonly IGraph _graph;

        public GraphManager(IGraph graph)
        {
            _graph = graph;
        }

        public void AddVertex(char vertex)
        {
            _graph.AddVertex(vertex);
        }

        public void AddEdge(char src, char dest)
        {
            _graph.AddEdge(src, dest);
        }

        public void PrintGraph()
        {
            _graph.Print();
        }

        public void DFS(char start)
        {
            Console.Write("Depth First Traversal (DFS): ");
            _graph.DFS(start);
            Console.WriteLine();
        }

        public void BFS(char start)
        {
            Console.Write("Breadth First Traversal (BFS): ");
            _graph.BFS(start);
            Console.WriteLine();
        }
    }
}