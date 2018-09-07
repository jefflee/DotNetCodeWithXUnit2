using Xunit;

namespace DemoCode.Tests.CollectionExecutionOrder
{
    [Collection("Zeta")]
    public class MemoryCalculatorAddTests
    {
        [Fact]
        public void ShouldAddPositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Add(10);
            sut.Add(5);

            Assert.Equal(15, sut.CurrentValue);
        }
    }
}
