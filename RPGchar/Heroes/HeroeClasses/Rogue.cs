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
    public class Rogue : Hero
    {
        public Rogue()
        {
            HeroClass = CharClasses.Rogue;
           
        }
        public override List<WeaponType> WeaponHandlingSkills()
        {
            return new List<WeaponType>() { WeaponType.Dagger, WeaponType.Sword };
        }

        public override List<ArmourType> ArmourWearingSkills()
        {
            return new List<ArmourType>() { ArmourType.Leather, ArmourType.Mail };
        }

        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 2, Intelligence = 1, Dexterity = 6, Vitality = 8 };
        
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1, Dexterity = 4, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes
        {
            get { return currentAttributes; }
            set { currentAttributes = value; }
        }
    

    public override void LevelUp()
        {
            Level++;
            currentAttributes = currentAttributes + gainedAttributes;


        }



        public override double CharacterDPS
        {
            get
            {
                return base.CharacterDPS;
            }
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
