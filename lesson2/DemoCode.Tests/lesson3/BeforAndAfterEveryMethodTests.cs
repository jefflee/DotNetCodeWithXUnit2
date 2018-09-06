using System;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class BeforAndAfterEveryMethodTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutput;

        private MemoryCalculator _sut;

        public BeforAndAfterEveryMethodTests(ITestOutputHelper helper)
        {
            _testOutput = helper;

            _testOutput.WriteLine("Creating sut");
            _sut = new MemoryCalculator();
        }

        [Fact]
        public void ShouldAdd()
        {
            _testOutput.WriteLine("Executing ShouldAdd");

            _sut.Add(10);
            _sut.Add(5);

            Assert.Equal(15, _sut.CurrentValue);
        }


        [Fact]
        public void ShouldSubtract()
        {
            _testOutput.WriteLine("Executing ShouldSubtract");

            _sut.Subtract(5);

            Assert.Equal(-5, _sut.CurrentValue);
        }


        [Fact]
        public void ShouldDivide()
        {
            _testOutput.WriteLine("Executing ShouldDivide");

            _sut.Add(10);
            _sut.Divide(2);

            Assert.Equal(5, _sut.CurrentValue);
        }


        public void Dispose()
        {
            _testOutput.WriteLine("Disposing sut");
            _sut.Dispose();
        }
    }
}
