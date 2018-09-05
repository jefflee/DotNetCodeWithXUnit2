using Xunit;

namespace DemoCode.Tests
{
    public class AssertingStringResults
    {
        [Fact]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.Equal("Sarah Smith", fullName);
        }



        [Fact]
        public void ShouldJoinNames_CaseInsensitiveAssertDemo()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("sarah", "smith");

            Assert.Equal("SARAH SMITH", fullName, ignoreCase: true);
        }



        [Fact]
        public void ShouldJoinNames_SubstringContents()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.Contains("Sarah", fullName);
        }


        [Fact]
        public void ShouldJoinNames_StartsWith()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.StartsWith("Sarah", fullName);
        }


        [Fact]
        public void ShouldJoinNames_EndsWith()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.EndsWith("ith", fullName);
        }


        [Fact]
        public void ShouldJoinNames_Regex()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
        }


    }
}
