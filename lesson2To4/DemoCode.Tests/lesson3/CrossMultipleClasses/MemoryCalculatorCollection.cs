using Xunit;

namespace DemoCode.Tests.CrossMultipleClasses
{
    [CollectionDefinition("MemoryCalculator Collection")]
    public class MemoryCalculatorCollection : ICollectionFixture<MemoryCalculatorFixture>
    {
    }
}
