using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGchar;
using RPGchar.Heroes.Attributes;
using RPGchar.Interfaces;
using RPGchar.Items;
using RPGchar.Heroes.HeroeClasses;
using Xunit;
using RPGchar.Heroes;

namespace RPGchar.UnitTests
{
    /// <summary>
    /// A class that represents tests of all possible hero classes
    /// </summary>
    public class AllHeroesTests
    {
        [Fact]
        public void Warior_WhenCreated_CheckDefaultAttributes()
        {
            //Strength = 5, Intelligence = 1, Dexterity = 2, Vitality = 10
            //Arrange
            var hero = new Warrior();
            
            //Act
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;
            

            //Assert
            Assert.Equal(5, strength);
            Assert.Equal(1, inteligence);
            Assert.Equal(2, dexterity);
            Assert.Equal(10, vitality);

        }
        [Fact]
        public void Mage_WhenCreated_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Mage();

            //Act
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;


            //Assert
            Assert.Equal(1, strength);
            Assert.Equal(8, inteligence);
            Assert.Equal(1, dexterity);
            Assert.Equal(5, vitality);


        }
        [Fact]
        public void Ranger_WhenCreated_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Ranger();

            //Act
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;


            //Assert
            Assert.Equal(1, strength);
            Assert.Equal(1, inteligence);
            Assert.Equal(7, dexterity);
            Assert.Equal(8, vitality);

        }

        [Fact]
        public void Rogue_WhenCreated_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Rogue();

            //Act
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;


            //Assert
            Assert.Equal(2, strength);
            Assert.Equal(1, inteligence);
            Assert.Equal(6, dexterity);
            Assert.Equal(8, vitality);

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
        [Fact]
        public void Rogue_WhenLeveledUp_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Rogue();

            //Act
            hero.LevelUp();
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;
            
            

            //Assert
            Assert.Equal(3, strength);
            Assert.Equal(2, inteligence);
            Assert.Equal(10, dexterity);
            Assert.Equal(11, vitality);
        }

        [Fact]
        public void Ranger_WhenLeveledUp_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Ranger();

            //Act
            hero.LevelUp();
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;
            


            //Assert
            Assert.Equal(2, strength);
            Assert.Equal(2, inteligence);
            Assert.Equal(12, dexterity);
            Assert.Equal(10, vitality);

        }

        [Fact]
        public void Warrior_WhenLeveledUp_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Warrior();

            //Act
            hero.LevelUp();
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;
            


            //Assert
            Assert.Equal(8, strength);
            Assert.Equal(2, inteligence);
            Assert.Equal(4, dexterity);
            Assert.Equal(15, vitality);

        }
        [Fact]
        public void Mage_WhenLeveledUp_CheckDefaultAttributes()
        {
            //Arrange
            var hero = new Mage();

            //Act
            hero.LevelUp();
            var strength = hero.CurrentAttributes.Strength;
            var inteligence = hero.CurrentAttributes.Intelligence;
            var dexterity = hero.CurrentAttributes.Dexterity;
            var vitality = hero.CurrentAttributes.Vitality;

            //Assert
            Assert.Equal(2, strength);
            Assert.Equal(13, inteligence);
            Assert.Equal(2, dexterity);
            Assert.Equal(8, vitality);
        }
    }
}
