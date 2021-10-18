using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Warrior : Hero
   {
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 5, Intelligence = 1, Dexterity = 2, Vitality = 10 };
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 3, Intelligence = 1, Dexterity = 2, Vitality = 5 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
        }
        public override void EquipArmor( ArmorType type)
        {
            throw new NotImplementedException();
        }

        public override void EquipWeapon( WeaponType type)
        {
            throw new NotImplementedException();
        }
    }
}
