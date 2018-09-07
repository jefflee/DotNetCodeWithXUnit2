using System;

namespace DemoCode.Tests.CrossMultipleClasses
{
    public class MemoryCalculatorFixture : IDisposable
    {
        public MemoryCalculator Sut { get; private set; }

        public MemoryCalculatorFixture()
        {
            Sut = new MemoryCalculator();
        }

        public void Dispose()
        {
            Sut.Dispose();
        }
    }
}