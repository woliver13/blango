using System;

namespace Woliver13.blango.Core
{
    public class Vertex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vertex(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vertex()
        {
        }

        public static Vertex operator -(Vertex a, Vertex b)
        {
            return new Vertex {X = a.X - b.X, Y = a.Y - b.Y, Z = a.Z - b.Z};
        }

        public static Vertex Cross(Vertex a, Vertex b)
        {
            return new Vertex
            {
                X = a.Y * b.Z - a.Z * b.Y,
                Y = a.Z * b.X - a.X * b.Z,
                Z = a.X * b.Y - a.Y * b.X
            };
        }

        public static Vertex Normalize(Vertex vertex)
        {
            var length = Math.Sqrt(vertex.X * vertex.X + vertex.Y * vertex.Y + vertex.Z * vertex.Z);
            return new Vertex { X = vertex.X / length, Y = vertex.Y / length, Z = vertex.Z / length };
        }
    }
}