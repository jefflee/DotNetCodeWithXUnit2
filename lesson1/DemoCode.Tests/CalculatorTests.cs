using System;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DemoCode.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            var sut = new Calculator();

            var result = sut.Add(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}
