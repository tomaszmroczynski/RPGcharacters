using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGchar;
using RPGchar.Heroes;
using RPGchar.Heroes.Attributes;
using RPGchar.Heroes.HeroeClasses;
using RPGchar.Items;
using RPGchar.Items.ArmourClasses;
using RPGchar.Items.WeaponClasses;
using Xunit;
using Xunit.Abstractions;

namespace RPGchar.UnitTests
{
    public class SingleHeroTests
    {
        private readonly ITestOutputHelper output;
        public SingleHeroTests(ITestOutputHelper output)
        {
            this.output = output;
        }
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
        [Fact]
        public void Warior_WhenLeveledUp_CheckSecoundaryStats()
        {
            //Arrange
            var hero = new Warrior();

            //Act
            hero.LevelUp();
            var health = hero.SecondaryAttributes.Health;
            var armourRating = hero.SecondaryAttributes.ArmourRating;
            var elementalResistance = hero.SecondaryAttributes.ElementalResistance;            

            //Assert
            Assert.Equal(150, health);
            Assert.Equal(12, armourRating);
            Assert.Equal(2, elementalResistance);
        }

        [Theory]
        [InlineData(-1, 0)]
        public void Hero_WhenTryToSetIncorrctLevel_CheckException(int value1, int value2)
        {
            var hero = new Warrior();
            Assert.Throws<ArgumentException>(() => hero.Level = value1);
            Assert.Throws<ArgumentException>(() => hero.Level = value2);
        }
        [Fact]
        public void Equip_WeaponLevelTooHigh_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Hero testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "King Axe of Haste",
                RequiredLevel = 2,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
            };
            string expected = "Weapon level too high!";
            // Act & Assert
            Exception exception = Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testAxe));
            string actual = exception.Message;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Equip_ArmourLevelTooHigh_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Hero testWarrior = new Warrior();
            Armour testArmour = new Armour()
            {
                Name = "Gothic Plate",
                RequiredLevel = 2,
                Slot = Slot.Body,
                Type = ArmourType.Plate,
                ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 3 }
            };
            string expected = "Armour level too high!";
            // Act & Assert
            Exception exception = Assert.Throws<InvalidArmourException>(() => testWarrior.EquipArmour(testArmour, Slot.Body));
            string actual = exception.Message;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Equip_WrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Hero testWarrior = new Warrior();
            Weapon testBow = new Weapon()
            {
                Name = "Bow of Eldros",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Bow,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
            };
            string expected = "Invalid weapon type for your class";
            // Act & Assert
            Exception exception = Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipWeapon(testBow));
            string actual = exception.Message;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Equip_WrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Hero testWarrior = new Warrior();
            Armour testArmour = new Armour()
            {
                Name = "Drunk Master Rags",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmourType.Cloth,
                ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 3 }
            };
            string expected = "Invalid armor type for your hero class";
            // Act & Assert
            Exception exception = Assert.Throws<InvalidArmourException>(() => testWarrior.EquipArmour(testArmour, Slot.Body));
            string actual = exception.Message;
            Assert.Equal(expected, actual);            
        }

        [Fact]
        public void Equip_ValidWeapon_ShouldShowSuccessMessage()
        {
            // Arrange
            Hero testWarrior = new Warrior();
            Weapon testSword = new Weapon()
            {
                Name = "Doombringer",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Sword,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
            };

            // Act & Assert

            testWarrior.EquipWeapon(testSword);
            var message = "New weapon equipped!";
            output.WriteLine(message);
        }
        [Fact]
        public void Equip_ValidArmour_ShouldShowSuccessMessage()
        {
            // Arrange
            Hero testMage = new Mage();
            Armour testArmour = new Armour()
            {
                Name = "Drunk Master Rags",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmourType.Cloth,
                ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 3 }
            };

            // Act & Assert

            testMage.EquipArmour(testArmour, Slot.Body);
            var message = "New armour equipped!";
            output.WriteLine(message);
           
        }
        [Fact]
        public void Warrior_NotEquipedAtLevel1_CheckDPS()
        {
            //Arrange
            var hero = new Warrior();

            double excepctedDPS = 1.00 * (1.00 + (5.00 / 100.00));
            //Act
            double actualDPS = hero.CharacterDPS;

            //Assert
            Assert.Equal(actualDPS, excepctedDPS);

        }
        [Fact]
        public void Warrior_WhenEquipedAxe_CheckDPS()
        {
            //Arrange
            Hero testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "King Axe of Haste",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            double excepctedDPS = (7.00 * 1.10) * (1.00 + (5.00 / 100));
            //Act
            testWarrior.EquipWeapon(testAxe);
            double actualDPS = testWarrior.CharacterDPS;

            //Assert
            Assert.Equal(actualDPS, excepctedDPS);

        }
        [Fact]
        public void Warrior_WhenEquipedWithBothWeaponAndArmour_CheckDPS()
        {
            //Arrange
            Hero testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                Name = "King Axe of Haste",
                RequiredLevel = 1,
                Slot = Slot.Weapon,
                Type = WeaponType.Axe,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            Armour testArmour = new Armour()
            {
                Name = "Gothic Plate",
                RequiredLevel = 1,
                Slot = Slot.Body,
                Type = ArmourType.Plate,
                ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 1 }
            };
            testWarrior.EquipWeapon(testAxe);
            testWarrior.EquipArmour(testArmour,Slot.Body);
            double excepctedDPS = (7.00 *1.10) * (1.00 + ((5.00+1.00) / 100.00));
            //Act
            double actualDPS = testWarrior.CharacterDPS;

            //Assert
            Assert.Equal(actualDPS, excepctedDPS);

        }

    }
}



