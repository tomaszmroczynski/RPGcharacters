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
    public class Rogue : Hero
    {
        public Rogue()
        {
            HeroClass = CharClasses.Rogue;
            currentAttributes = new PrimaryAttributes { Strength = 2, Intelligence = 1, Dexterity = 6, Vitality = 8 };
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

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
            Console.WriteLine($"Congratulations {Name} You have leveled up, and your actual level is {Level} ");

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


    }
}
