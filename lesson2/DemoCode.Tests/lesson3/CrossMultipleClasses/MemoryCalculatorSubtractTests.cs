using Xunit;

namespace DemoCode.Tests.CrossMultipleClasses
{
    [Collection("MemoryCalculator Collection")]
    public class MemoryCalculatorSubtractTests
    {     
        private readonly MemoryCalculatorFixture _fixture;        

        public MemoryCalculatorSubtractTests(MemoryCalculatorFixture fixture)
        {            
            _fixture = fixture;

            _fixture.Sut.Clear();
        }

        [Fact]
        public void ShouldSubtractPositiveNumbers()
        {    
            _fixture.Sut.Subtract(5);

            Assert.Equal(-5, _fixture.Sut.CurrentValue);
        }

        [Fact]
        public void ShouldSubtractNegativeNumbers()
        {
            _fixture.Sut.Subtract(-5);

            Assert.Equal(5, _fixture.Sut.CurrentValue);
        }
    }
}
