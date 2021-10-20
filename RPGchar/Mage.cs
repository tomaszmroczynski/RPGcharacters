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
        private readonly List<ArmourType> weaponWearingSkills = new List<ArmourType>() { ArmourType.Cloth };


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
        public override void EquipArmour( Armour armour, Slot slot)
        {

            //try
            //{
            //     Equipment.Add(slot, armour);  
            //     Console.WriteLine($"What great {armour.Type} u have equiped ");
            //}
            //catch (InvalidArmourExeption ex)
            //{

            //    Console.WriteLine(ex.ToString());
            //}

            if (!weaponWearingSkills.Contains(armour.Type))
            {
                throw new InvalidArmourExeption($"{Name} can`t use {armour.Name} {armour.Type} Armour");

            }
            else if (armour.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{armour.Name}{armour.Type} required level  is too high to use it right now");
            }
            else if (slot == Slot.Weapon)
            {
                throw new InvalidOperationException("You cant wear Armour in your hands");
            }
            else
            {

                Equipment.Add(slot, armour);
                Console.WriteLine($"What great {armour.Type} u have equiped ");
            }




        }

        public override void SearchChest()
        {
            
            



            
        }
    }
}
