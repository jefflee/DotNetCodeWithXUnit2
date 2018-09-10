using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Tests.extra.AlphabatOrder
{
    [TestCaseOrderer("DemoCode.Tests.extra.AlphabatOrder.AlphabeticalOrderer", "DemoCode.Tests")]
    public class AlphabeticalOrderTest
    {
        public static bool Test1Called;
        public static bool Test2Called;
        public static bool Test3Called;

        [Fact]
        public void Test1()
        {
            Test1Called = true;

            Assert.False(Test2Called);
            Assert.False(Test3Called);
        }

        [Fact]
        public void Test2()
        {
            Test2Called = true;

            Assert.True(Test1Called);
            Assert.False(Test3Called);
        }

        [Fact]
        public void Test3()
        {
            Test3Called = true;

            Assert.True(Test1Called);
            Assert.True(Test2Called);
        }
    }
}
