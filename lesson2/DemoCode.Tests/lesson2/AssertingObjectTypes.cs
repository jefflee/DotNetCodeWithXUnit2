using Xunit;

namespace DemoCode.Tests.lesson2
{
    public class AssertingObjectTypes
    {
        [Fact]
        public void ShouldCreateNormalEnemy_SimpleExample()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            Assert.IsType(typeof(NormalEnemy), enemy);
        }


        [Fact]
        public void ShouldCreateNormalEnemy_Cast()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            NormalEnemy normalEnemy = Assert.IsType<NormalEnemy>(enemy);

            Assert.Equal(10, normalEnemy.Power);
        }

        [Fact]
        public void ShouldCreateNormalEnemy_ExcludeDerivedTypes()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            //This assert will fail, because enemy's type is NormalEnemy which is derived from Enemy.
            //Assert.IsType(typeof(Enemy), enemy);
        }

        [Fact]
        public void ShouldCreateNormalEnemy_IncludeDerivedTypes()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            Assert.IsAssignableFrom(typeof(Enemy), enemy);
        }

        [Fact]
        public void ShouldCreateNormalEnemy_IncludeDerivedTypes_Cast()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            Enemy normalEnemy = Assert.IsAssignableFrom<Enemy>(enemy);

            Assert.Equal("Default Name", normalEnemy.Name);
        }
    }
}
