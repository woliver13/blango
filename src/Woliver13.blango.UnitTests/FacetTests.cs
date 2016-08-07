using NUnit.Framework;
using Woliver13.blango.Core;

namespace Woliver13.blango.UnitTests
{
    [TestFixture]
    public class FacetTests
    {
        [Test]
        public void ShouldProduceNegZOnlyNormal()
        {
            // Clock wise points
            var facet = new Facet
            {
                V0 = new Vertex(1, 0, 0),
                V1 = new Vertex(0, 1, 0),
                V2 = new Vertex(1, 1, 0)
            };
            Assert.AreEqual(facet.Normal.X, 0.0);
            Assert.AreEqual(facet.Normal.Y, 0.0);
            Assert.AreEqual(facet.Normal.Z, -1.0);
        }

        [Test]
        public void ShouldProduceZOnlyNormal()
        {
            // Counter clock wise points
            var facet = new Facet
            {
                V0 = new Vertex(1, 1, 0),
                V1 = new Vertex(0, 1, 0),
                V2 = new Vertex(1, 0, 0)
            };
            Assert.AreEqual(facet.Normal.X, 0.0);
            Assert.AreEqual(facet.Normal.Y, 0.0);
            Assert.AreEqual(facet.Normal.Z, 1.0);
        }
    }
}