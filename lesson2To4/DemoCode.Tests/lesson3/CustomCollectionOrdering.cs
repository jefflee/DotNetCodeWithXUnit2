using System;
using System.Threading;
using Xunit;

namespace DemoCode.Tests.lesson3
{
    [Trait("Category", "Error Checking")]
    public class CustomCollectionOrdering
    {
        [Fact]
        public void Category_ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide2(10, 0));
        }


        [Fact]
        public void Category_ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();

            ArgumentOutOfRangeException thrownException =
                Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide2(201, 1));

            Assert.Equal("value", thrownException.ParamName);

        }

        [Fact]
        [Trait("Category", "Slow Running")]
        public void Category_ShouldErrorWhenNumberTooBig_SLOW()
        {
            var sut = new Calculator();

            // Simulate long running test
            Thread.Sleep(TimeSpan.FromSeconds(2));

            ArgumentOutOfRangeException thrownException =
                Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide2(201, 1));

            Assert.Equal("value", thrownException.ParamName);
        }


    }
}
