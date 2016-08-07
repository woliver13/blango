using System;
using System.Collections.Generic;
using System.IO;
using Woliver13.blango.Core;

namespace blango
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var facets = MakeTetraHedron();
            string outputFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "test.stl");
            using (var writer = new StlWriter(outputFileName))
                writer.Write(facets);
        }

        private static IEnumerable<Facet> MakeTetraHedron()
        {
            var p1 = new Vertex(-5, -4.33, 0);
            var p2 = new Vertex(5, -4.33, 0);
            var p3 = new Vertex(0, 4.33, 0);
            var p4 = new Vertex(0, -1.443, 8.165);

            var facets = new List<Facet>();
            var f1 = new Facet
            {
                V0 = p1,
                V1 = p3,
                V2 = p2
            };
            facets.Add(f1);
            var f2 = new Facet
            {
                V0 = p2,
                V1 = p3,
                V2 = p4
            };
            facets.Add(f2);
            var f3 = new Facet
            {
                V0 = p3,
                V1 = p1,
                V2 = p4
            };
            facets.Add(f3);
            var f4 = new Facet
            {
                V0 = p1,
                V1 = p2,
                V2 = p4
            };
            facets.Add(f4);
            return facets;
        }
    }
}