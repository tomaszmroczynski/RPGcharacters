using RPGchar.Heroes.Attributes;
using RPGchar.Items.ArmourClasses;
using RPGchar.Items.WeaponClasses;
using System.Collections.Generic;

namespace RPGchar.Heroes.HeroeClasses
{
    public class Ranger : Hero
    {
        /// <summary>
        /// A class that represents one of the existing type of heroes
        /// </summary>
        public Ranger()
        {
            HeroClass = CharClasses.Ranger;     
        }
        /// <summary>
        /// A method that stores weapon types which hero class is able to use
        /// </summary>
        /// <returns>Weapon types</returns>
        public override List<WeaponType> WeaponHandlingSkills()
        {
            return new List<WeaponType>() { WeaponType.Bow };
        }
        /// <summary>
        /// A method that stores armour types which hero class is able to use
        /// </summary>
        /// <returns>Armur types</returns>
        public override List<ArmourType> ArmourWearingSkills()
        {
            return new List<ArmourType>() { ArmourType.Leather, ArmourType.Mail };
        }
        /// <summary>
        /// A field containg attributes when hero is created
        /// </summary>
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1 , Dexterity= 7, Vitality = 8 };
        /// <summary>
        /// A field containg attributes that hero gains when levels up
        /// </summary>
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1, Dexterity = 5, Vitality= 2 };

        public PrimaryAttributes CurrentAttributes
        {
            get { return currentAttributes; }
            set { currentAttributes = value; }
        }
        public override double CharacterDPS
        {
            get
            {
                return base.CharacterDPS;
            }
        }

        public override void LevelUp()
        {
            Level++;
            currentAttributes = currentAttributes + gainedAttributes;
        }

        public override PrimaryAttributes GetCurrentAttributes()
        {
            return CurrentAttributes;
        }
    }
}

