using NUnit.Framework;

namespace Test {
    [TestFixture]
    public class NUnitTests {
        [Test]
        public void SomePassingTest() {
            Assert.AreEqual(5, 5);
        }

        [Test]
        public void SomeFailingTest()
        {
        }
    }
}
