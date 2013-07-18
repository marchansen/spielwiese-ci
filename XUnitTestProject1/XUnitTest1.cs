using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class XUnitTest1
    {



        [Fact]
        public void XUnitSuccessTest()
        {
            Assert.Equal(4,4);
            Console.Out.WriteLine("dvsfvs");
        }

        [Fact]
        public void XUnitFailureTest()
        {
            Assert.Equal("MCMXCIX", Statistics.Romanish (1999));
        }
    }
}
