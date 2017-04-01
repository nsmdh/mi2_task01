using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphDrawer
{
    class Graph
    {
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();

        public void dfs(Vertex start)
        {
            List<Vertex> reached = new List<Vertex>();
            Stack<Vertex> todo = new Stack<Vertex>();

            Console.WriteLine("Not implemented.");
        }

        public void bfs(Vertex start)
        {
            List<Vertex> reached = new List<Vertex>();
            Queue<Vertex> todo = new Queue<Vertex>();

            Console.WriteLine("Not implemented.");
        }

        private List<Vertex> getNeighbours(Vertex u)
        {
            List<Vertex> neighbours = new List<Vertex>();
            foreach (Edge edge in edges)
            {
                if (u.Equals(edge.vertex1))
                {
                    neighbours.Add(edge.vertex2);
                }
                else if (u.Equals(edge.vertex2))
                {
                    neighbours.Add(edge.vertex1);
                }
            }
            return neighbours;
        }

        public static Graph generateSampleGraph()
        {
            Graph g = new Graph();
            for (int i = 1; i <= 11; i++)
            {
                for (int j = 1; j <= 11; j++)
                {
                    Vertex v = new Vertex(i * 1.0f / 12, j * 1.0f / 12);
                    g.addVertex(v);
                }
            }

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (j < 10)
                    {
                        g.addEdge(new Edge(g.getVertex(i * 11 + j), g.getVertex(i * 11 + j + 1)));
                    }
                    if (i < 10)
                    {
                        g.addEdge(new Edge(g.getVertex(i * 11 + j), g.getVertex((i + 1) * 11 + j)));
                    }
                }
            }
            return g;
        }

        public Vertex getVertexByCoord(float x, float y, float rx, float ry)
        {
            foreach (Vertex vertex in vertices)
            {
                if (vertex.isAtCoord(x, y, rx, ry))
                {
                    return vertex;
                }
            }
            return null;
        }

        public void addVertex(Vertex v)
        {
            vertices.Add(v);
        }

        public Vertex getVertex(int i)
        {
            return vertices.ElementAt(i);
        }

        public int numVertices()
        {
            return vertices.Count;
        }

        public int numEdges()
        {
            return edges.Count;
        }

        public Edge getEdge(int i)
        {
            return edges.ElementAt(i);
        }

        public void addEdge(Edge e)
        {
            if (!e.vertex1.Equals(e.vertex2))
            {
                edges.Add(e);
            }
        }

        internal void remove(Vertex v)
        {
            for (int i = edges.Count() - 1; i >= 0; i--)
            {
                Edge edge = edges.ElementAt(i);
                if (v.Equals(edge.vertex1) || v.Equals(edge.vertex2))
                {
                    edges.Remove(edge);
                }
            }
            vertices.Remove(v);
        }

        internal void clearNamesOfVertices()
        {
            foreach (Vertex vertex in vertices)
            {
                vertex.name = "";
            }
        }
    }

}
