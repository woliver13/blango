using NUnit.Framework;
using Woliver13.blango.Core;

namespace Woliver13.blango.UnitTests
{
    [TestFixture]
    public class VertexTests
    {
        [Test]
        public void ShouldProduceDifference()
        {
            var a = new Vertex(3, 2, 1);
            var b = new Vertex(1, 1, 1);
            Vertex c = a - b;
            Assert.AreEqual(c.X, 2.0);
            Assert.AreEqual(c.Y, 1.0);
            Assert.AreEqual(c.Z, 0.0);
        }

        [Test]
        public void ShoudProduceCrossProduct()
        {
            var a = new Vertex(3, 2, 1);
            var b = new Vertex(1, 1, 1);
            var c = Vertex.Cross(a, b);
            Assert.AreEqual(c.X, 1.0);
            Assert.AreEqual(c.Y, -2.0);
            Assert.AreEqual(c.Z, 1.0);
        }

        [Test]
        public void ShouldProduceVectorLengthOfOne()
        {
            var a = new Vertex(3, 0, 0);
            var b = Vertex.Normalize(a);
            Assert.AreEqual(b.X, 1.0);
            Assert.AreEqual(b.Y, 0.0);
            Assert.AreEqual(b.Z, 0.0);
        }
    }
}