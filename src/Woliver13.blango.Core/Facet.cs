namespace Woliver13.blango.Core
{
    public class Facet
    {
        private Vertex _normal;

        public Vertex Normal
        {
            get { return _normal ?? (_normal = GetNormalByRightHandRule(V0, V1, V2)); }
            set { _normal = value; }
        }

        public Vertex V0 { get; set; }
        public Vertex V1 { get; set; }
        public Vertex V2 { get; set; }

        private static Vertex GetNormalByRightHandRule(Vertex a, Vertex b, Vertex c)
        {
            return Vertex.Normalize(Vertex.Cross(a - b, b - c));
        }
    }
}