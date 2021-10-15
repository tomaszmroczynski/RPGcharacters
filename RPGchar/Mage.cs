using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Mage : Hero
    {

         readonly List<WeaponType> weaponHandlingSkills = new List<WeaponType>() { WeaponType.Staff, WeaponType.Wand};
        // i dont know if it is right way to list items
 


        public override void EquipWeapon(Hero name, WeaponType type)
        {
            Weapon weapon = new Weapon();
            weapon.Type = type;
            if (weaponHandlingSkills.Contains(type)) 
            {
                name.Equipment.Add(Slot.Weapon, weapon);
            } 
            else 
            {
                Console.WriteLine($"{this.Name} cant use {type} weapon");
                    
            };
           


        }
        public override void EquipArmor(Hero name, ArmorType type)
        {
            Armor armor = new Armor();
            armor.Type = type;
  
            switch (type)
            {
                case ArmorType.Cloth:
                    name.Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Leather:
                    name.Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Mail:
                    name.Equipment.Add(Slot.Body, armor);
                    break;
                case ArmorType.Plate:
                    name.Equipment.Add(Slot.Body, armor);
                    break;

            }
            
        }

    }
}
