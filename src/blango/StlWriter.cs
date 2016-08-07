using System;
using System.Collections.Generic;
using System.IO;
using Woliver13.blango.Core;

namespace blango
{
    public class StlWriter : IDisposable
    {
        private readonly string _fileName;

        public StlWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool managed)
        {
        }

        public void Write(IEnumerable<Facet> facets)
        {
            using (var sr = new StreamWriter(_fileName))
            {
                sr.WriteLine("solid tetrahedron");
                foreach (Facet facet in facets)
                {
                    sr.WriteLine("  facet normal {0:F4} {1:F4} {2:F4}", facet.Normal.X, facet.Normal.Y, facet.Normal.Z);
                    sr.WriteLine("    outer loop");
                    sr.WriteLine("      vertex {0:F4} {1:F4} {2:F4}", facet.V0.X, facet.V0.Y, facet.V0.Z);
                    sr.WriteLine("      vertex {0:F4} {1:F4} {2:F4}", facet.V1.X, facet.V1.Y, facet.V1.Z);
                    sr.WriteLine("      vertex {0:F4} {1:F4} {2:F4}", facet.V2.X, facet.V2.Y, facet.V2.Z);
                    sr.WriteLine("    endloop");
                    sr.WriteLine("  endfacet");
                }
                sr.WriteLine("endsolid tetrahedron");
            }
        }
    }
}