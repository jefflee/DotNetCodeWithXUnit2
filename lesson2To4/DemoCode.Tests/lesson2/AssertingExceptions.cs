using System;
using Xunit;

namespace DemoCode.Tests.lesson2
{
    public class AssertingExceptions
    {
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide2(10, 0));
        }


        [Fact]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();

            ArgumentOutOfRangeException thrownException =
                Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide2(201, 1));

            Assert.Equal("value", thrownException.ParamName);

        }

    }
}
