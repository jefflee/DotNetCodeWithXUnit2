using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace DemoCode.Tests.lesson4.DatasourceAttribute
{
    public class CsvTestDataAttribute : DataAttribute
    {
        private readonly string _csvFileName;

        public CsvTestDataAttribute(string csvFileName)
        {
            _csvFileName = csvFileName;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            string[] csvLines = File.ReadAllLines(_csvFileName);

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

    public class MemoryCalculatorTests
    {
        [Theory]
        [CsvTestData("lesson4\\ExternalData\\TestData.csv")]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}
