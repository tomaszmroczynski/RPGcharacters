using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGchar;
using RPGchar.Heroes.HeroeClasses;
using Xunit;

namespace RPGchar.UnitTests
{
    public class HeroTests
    {
        [Fact]
        public void Hero_WhenCreated_ShouldHaveLevel1()
        {
            //Arrange
            var hero = new Mage();

            //Act
            var result = hero.Level;


            //Assert
            Assert.Equal(1, result);
            
        }
        [Fact]
        public void Hero_WhenLeveledUp_ShouldHaveLevel2()
        {
            //Arrange
            var hero = new Mage();

            //Act
            hero.LevelUp();
            var result = hero.Level;

            //Assert
            Assert.Equal(2, result);

        }


    }
}
