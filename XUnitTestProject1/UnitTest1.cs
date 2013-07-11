using System;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void XUnitSuccessTest()
        {
            Assert.Equal(4,4);
        }

        [Fact]
        public void XUnitFailureTest()
        {
            Assert.Equal(4, 5);
        }
    }
}
