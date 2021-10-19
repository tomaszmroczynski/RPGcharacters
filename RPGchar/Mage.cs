using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Mage : Hero
    {


        private readonly List<WeaponType> weaponHandlingSkills = new List<WeaponType>() { WeaponType.Staff, WeaponType.Wand};
        private readonly List<ArmorType> weaponWearingSkills = new List<ArmorType>() { ArmorType.Cloth };


        public PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 8, Dexterity = 1, Vitality = 5 };
        public readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 5, Dexterity = 1, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
            Level++;
            Console.WriteLine($"Congratulations {Name} You have leveled up, and your actual level is {Level} ");
            Console.WriteLine("Your updated atributes are:");
            Console.WriteLine($"Strength {currentAttributes.Strength}");
            Console.WriteLine($"Dexterity {currentAttributes.Dexterity}");
            Console.WriteLine($"Intelligence {currentAttributes.Intelligence}");
            Console.WriteLine($"Vitality {currentAttributes.Vitality}");
        }

        public override void EquipWeapon(Weapon weapon) 
        {
            if (!weaponHandlingSkills.Contains(weapon.Type))
            {
                throw new InvalidWeaponException($"{Name} can`t use {weapon.Name}{weapon.Type} weapon");

            }
            else if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{weapon.Name}{weapon.Type} required level  is too high to use it right now");
            } else {

                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine($"What great {weapon.Type} u have equiped ");
            }

     

        }
        public override void EquipArmor( Armor armor, Slot slot)
        {


            if (!weaponWearingSkills.Contains(armor.Type))
            {
                throw new InvalidArmorExeption($"{Name} can`t use {armor.Name} {armor.Type} armor");

            }
            else if (armor.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{armor.Name}{armor.Type} required level  is too high to use it right now");
            }
            else if (slot == Slot.Weapon)
            {
                throw new InvalidOperationException("You cant wear armor in your hands");
            } 
            else
            {

                Equipment.Add(slot, armor); //important to make 
                Console.WriteLine($"What great {armor.Type} u have equiped ");
            }
            //switch (armor.Type)
            //{
            //    case ArmorType.Cloth:
            //        Equipment.Add(Slot.Body, armor);
            //        break;
            //    case ArmorType.Leather:
            //        Equipment.Add(Slot.Body, armor);
            //        break;
            //    case ArmorType.Mail:
            //        Equipment.Add(Slot.Body, armor);
            //        break;
            //    case ArmorType.Plate:
            //        Equipment.Add(Slot.Body, armor);
            //        break;}

            
            
        }

    }
}
