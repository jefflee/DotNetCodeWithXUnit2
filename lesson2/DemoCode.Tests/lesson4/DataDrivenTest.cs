using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace DemoCode.Tests
{
    public class DataDrivenTest
    {

        [Theory]
        [InlineData(5, 10, -15)]
        [InlineData(-5, -10, 15)]
        [InlineData(10, 0, -10)]
        [InlineData(0, 0, 0)]
        [InlineData(-99, 99, 0)]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}