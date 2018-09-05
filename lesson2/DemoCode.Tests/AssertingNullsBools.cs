using System;
using Xunit;

namespace DemoCode.Tests
{
    public class AssertingNullsBools
    {
        [Fact]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayerCharacter();

            Assert.False(string.IsNullOrWhiteSpace(sut.Name));
        }

        [Fact]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            Assert.Null(sut.NickName);
        }

        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

    }
}
