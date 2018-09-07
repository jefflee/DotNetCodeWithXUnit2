using Xunit;

namespace DemoCode.Tests.CollectionExecutionOrder
{   
    public class MemoryCalculatorDivideTests
    {
        [Fact]
        public void ShouldDividePositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Add(10);
            sut.Divide(2);

            Assert.Equal(5, sut.CurrentValue);
        }
    }
}
