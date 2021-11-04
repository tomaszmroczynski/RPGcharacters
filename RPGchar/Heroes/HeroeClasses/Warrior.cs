using RPGchar.Heroes.Attributes;
using RPGchar.Items.ArmourClasses;
using RPGchar.Items.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes.HeroeClasses
{
    public class Warrior : Hero
   {
        public Warrior()
        {
          
            HeroClass = CharClasses.Warrior;
           

        }
        public override List<WeaponType> WeaponHandlingSkills()
        {
            return new List<WeaponType>() { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };
        }

        public override List<ArmourType> ArmourWearingSkills()
        {
            return new List<ArmourType>() { ArmourType.Mail, ArmourType.Plate };
        }
        
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 5, Intelligence = 1, Dexterity = 2, Vitality = 10 };
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 3, Intelligence = 1, Dexterity = 2, Vitality = 5 };

        public PrimaryAttributes CurrentAttributes
        {
            get { return currentAttributes; }
            set { currentAttributes = value; }
        }

        public override  double CharacterDPS
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



        public override void SearchChest()
        {
            throw new NotImplementedException();
        }

        public override PrimaryAttributes GetCurrentAttributes()
        {
            return CurrentAttributes;
        }


    }
}
