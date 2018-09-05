using Xunit;

namespace DemoWpfApplication.Tests
{
    public class MainViewModelTests
    {
        [Fact]
        public void ShouldRaisePropertyChangedOnConvert()
        {
            var sut = new MainViewModel();

            Assert.PropertyChanged(sut, "Text", () => sut.ConvertToUpperCommand.Execute(null));
        }
    }
}
