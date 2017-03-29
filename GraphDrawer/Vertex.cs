using System;

namespace GraphDrawer
{
    class Vertex
    {
        public float x { get; set; }
        public float y { get; set; }
        public float radius { get; set; }
        public String name { get; set; }

        public Vertex(float x, float y, String name)
        {
            this.x = x;
            this.y = y;
            this.radius = 0.02f;
            this.name = name;
        }

        public bool isAtCoord(float x, float y, float rx, float ry)
        {
            return Math.Pow(x - this.x, 2) / Math.Pow(radius * rx, 2) + Math.Pow(y - this.y, 2) / Math.Pow(radius * ry, 2) <= 1;
        }
    }
}
