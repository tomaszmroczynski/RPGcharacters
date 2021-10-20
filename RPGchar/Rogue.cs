﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Rogue : Hero
    {
        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 2, Intelligence = 1, Dexterity = 6, Vitality = 8 };
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1, Dexterity = 4, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
        }
        public override void EquipArmour( Armour armour, Slot slot)
        {
            throw new NotImplementedException();
        }

        public override void EquipWeapon( Weapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}
