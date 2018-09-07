using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace DemoCode.Tests.ExternalData
{
    public class MemoryCalculatorTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("lesson4\\ExternalData\\TestData.csv");

                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }

                return testCases;
            }
        }
    }

    public class MemoryCalculatorTests
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(MemoryCalculatorTestData))]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}