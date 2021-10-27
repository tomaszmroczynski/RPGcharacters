using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Warrior : Hero
   {
        private readonly List<WeaponType> WeaponHandlingSkills = new List<WeaponType>() { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword };

        private readonly List<ArmourType> ArmourWearingSkills = new List<ArmourType>() { ArmourType.Mail, ArmourType.Plate };

        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 5, Intelligence = 1, Dexterity = 2, Vitality = 10 };
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 3, Intelligence = 1, Dexterity = 2, Vitality = 5 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override  double CharacterDPS
        {
            get
            {
                return base.CharacterDPS;
            }
        }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (!WeaponHandlingSkills.Contains(weapon.Type))
            {
                throw new InvalidWeaponException($"{Name} can`t use {weapon.Name}{weapon.Type} weapon");

            }
            else if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{weapon.Name}{weapon.Type} required level  is too high to use it right now");
            }
            else
            {

                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine($"What great {weapon.Type} u have equiped ");
            }
        }

        public override void SearchChest()
        {
            throw new NotImplementedException();
        }

        public override void EquipArmour(Armour armour, Slot slot)
        {
            if (!ArmourWearingSkills.Contains(armour.Type))
                throw new InvalidArmourExeption("wrong armor type for your hero class");
            else if (armour.RequiredLevel > Level)
                throw new InvalidArmourExeption("too low character level");
            else if (slot == Slot.Weapon)
                throw new InvalidItemException("wrong item slot");
            else
            {
                Equipment.Add(slot, armour);
                Console.WriteLine($"What great {armour.Type} u have equiped ");
            }
        }
    }
}
