namespace DataStructures.Graph
{
    public class Edge
    {
        public char Src { get; }
        public char Dest { get; }

        public Edge(char src, char dest)
        {
            Src = src;
            Dest = dest;
        }
    }
}