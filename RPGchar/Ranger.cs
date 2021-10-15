using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Ranger : Hero
    {


            
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 3 };
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 2, Intelligence = 4 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
        }


        public override void EquipArmor(Hero name, ArmorType type)
        {
            throw new NotImplementedException();
        }

        public override void EquipWeapon(Hero name, WeaponType type)
        {
            throw new NotImplementedException();
        }
    }
}

