using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace DemoCode.Tests
{
    public class MemoryCalculatorTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 5, 10, -15 };
                yield return new object[] { -5, -10, 15 };
                yield return new object[] { 10, 0, -10 };
                yield return new object[] { 0, 0, 0 };
                yield return new object[] { -99, 99, 0 };
            }
        }
    }

    public class MemoryCalculatorTests2
    {
        [Theory]
        [MemberData("TestData", MemberType=typeof(MemoryCalculatorTestData))]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}