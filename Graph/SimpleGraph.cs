using System.Collections.Generic;
using System;

namespace DataStructures.Graph
{
    public class SimpleGraph : IGraph
    {
        private readonly Dictionary<char, List<char>> _adjList;

        public SimpleGraph()
        {
            _adjList = new Dictionary<char, List<char>>();
        }

        public void AddVertex(char vertex)
        {
            if (!_adjList.ContainsKey(vertex))
            {
                _adjList[vertex] = new List<char>();
            }
        }

        public void AddEdge(char src, char dest)
        {
            AddVertex(src);
            AddVertex(dest);
            _adjList[src].Add(dest);
        }

        public void Print()
        {
            foreach (var entry in _adjList)
            {
                Console.Write($"{entry.Key} -> ");
                if (entry.Value.Count == 0)
                {
                    Console.Write("No adjacent vertices");
                }
                foreach (var neighbor in entry.Value)
                {
                    Console.Write($"{neighbor}\t");
                }
                Console.WriteLine();
            }
        }

        public void DFS(char start)
        {
            var visited = new HashSet<char>();
            DFSUtil(start, visited);
        }

        private void DFSUtil(char vertex, HashSet<char> visited)
        {
            visited.Add(vertex);
            Console.Write(vertex + " ");

            if (_adjList.ContainsKey(vertex))
            {
                foreach (var neighbor in _adjList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        DFSUtil(neighbor, visited);
                    }
                }
            }
        }

        public void BFS(char start)
        {
            var visited = new HashSet<char>();
            var queue = new Queue<char>();

            visited.Add(start);
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                char vertex = queue.Dequeue();
                Console.Write(vertex + " ");

                if (_adjList.ContainsKey(vertex))
                {
                    foreach (var neighbor in _adjList[vertex])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
        }
    }
}