using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Mage : Hero
    {

        public Mage()
        {

        }

         readonly List<WeaponType> weaponHandlingSkills = new List<WeaponType>() { WeaponType.Staff, WeaponType.Wand};
        // i dont know if it is right way to list items

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

        public override void EquipWeapon( WeaponType type) //its wrong hero cant just equip a type of weapon it has to e instance of weapon
        {
            Weapon weapon = new Weapon();
            weapon.Type = type;
            if (weaponHandlingSkills.Contains(type)) 
            {
                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine($"What great {type} u have equiped ");
            } 
            else 
            {
                Console.WriteLine($"{Name} can`t use {type} weapon");
                    
            };
           


        }
        public override void EquipArmor( ArmorType type)
        {
            Armor armor = new Armor();
            armor.Type = type;
  
            switch (type)
            {
                case ArmorType.Cloth:
                    Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Leather:
                    Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Mail:
                    Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Plate:
                    Equipment.Add(Slot.Body, armor);
                    break;

            }
            
        }

    }
}
