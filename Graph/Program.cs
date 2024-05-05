using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new SimpleGraph();
            var graphManager = new GraphManager(graph);

            // Add vertices
            graphManager.AddVertex('S');   // 0
            graphManager.AddVertex('A');   // 1
            graphManager.AddVertex('B');   // 2
            graphManager.AddVertex('C');   // 3
            graphManager.AddVertex('D');   // 4

            // Add edges
            graphManager.AddEdge('S', 'A');    // S - A
            graphManager.AddEdge('S', 'B');    // S - B
            graphManager.AddEdge('S', 'C');    // S - C
            graphManager.AddEdge('A', 'D');    // A - D
            graphManager.AddEdge('B', 'D');    // B - D
            graphManager.AddEdge('C', 'D');    // C - D

            // Print the graph
            Console.WriteLine("The graph created is:");
            graphManager.PrintGraph();

            // Perform DFS and BFS
            char startVertex = 'S';
            graphManager.DFS(startVertex);
            graphManager.BFS(startVertex);
            Console.ReadKey();
        }
    }
}
