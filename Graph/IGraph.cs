namespace DataStructures.Graph
{
    public interface IGraph
    {
        void AddVertex(char vertex);
        void AddEdge(char src, char dest);
        void Print();
        void DFS(char start);
        void BFS(char start);
    }
}