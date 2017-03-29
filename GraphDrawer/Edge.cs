namespace GraphDrawer
{
    internal class Edge
    {
        public Vertex vertex1 { get; set; }
        public Vertex vertex2 { get; set; }
        public Edge(Vertex vertex1, Vertex vertex2)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
        }
    }
}