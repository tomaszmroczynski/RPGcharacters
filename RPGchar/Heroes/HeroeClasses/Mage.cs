using RPGchar.Heroes.Attributes;
using RPGchar.Items.Armour;
using RPGchar.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes.HeroeClasses
{
    public class Mage : Hero
    {
        public Mage()
        {
            HeroClass = CharClasses.Mage;
        }
        public override List<WeaponType> WeaponHandlingSkills() 
        {
            return new List<WeaponType>() { WeaponType.Staff, WeaponType.Wand }; 
        }
        public override List<ArmourType> ArmourWearingSkills() 
        { 
            return new List<ArmourType>() { ArmourType.Cloth };
        }

        //private  PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 8, Dexterity = 1, Vitality = 5 };
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 8, Dexterity = 1, Vitality = 5 };
        public readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 5, Dexterity = 1, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }




        public override double CharacterDPS
        {
            get
            {
                return base.CharacterDPS;
            }
        }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
            Level++;

        }




        public override void SearchChest()
        {
            
            



            
        }


    }
}
