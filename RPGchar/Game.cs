using RPGchar.Heroes;
using RPGchar.Heroes.Attributes;
using RPGchar.Heroes.HeroeClasses;
using RPGchar.Items;

using RPGchar.Items.ArmourClasses;

using RPGchar.Items.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace RPGchar
{
    public class Game
    {
 
        public void StartGame(string input)
        {
            if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || input == "1")
            {
                Console.WriteLine("Oh my head.....aahh, you open your eyes");
                Thread.Sleep(1000);
            }
            else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase) || input == "2")
            {
                Console.WriteLine("bye, bye");
                input = "exit";
            }
        }

        public Hero NewHero(string input)
        {
            var values = Enum.GetValues(typeof(CharClasses));
            int idx = 0;
            foreach (var item in values)
            {
                idx++;               
                Console.WriteLine($"{idx} {item}");
                Thread.Sleep(1000);
            }
            input = Console.ReadLine();
     
            return input == "1" ? new Mage() : input == "2" ? new Warrior() : input == "3" ? new Rogue() : input == "4" ? new Ranger() : default; 
        }

        public List<Item> InventoryChest
        {
            get
            {
                InventoryChest.Add(new Weapon()
                {
                    Name = "Doombringer",
                    RequiredLevel = 2,
                    Slot = Slot.Weapon,
                    Type = WeaponType.Sword,
                    WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
                });
                InventoryChest.Add(new Weapon()
                {
                    Name = "King Sword of Haste",
                    RequiredLevel = 3,
                    Slot = Slot.Weapon,
                    Type = WeaponType.Axe,
                    WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
                });
                InventoryChest.Add(new Armour()
                {
                    Name = "Gothic Plate",
                    RequiredLevel = 2,
                    Slot = Slot.Body,
                    Type = ArmourType.Plate,
                    ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 3 }
                });
                InventoryChest.Add(new Armour()
                {
                    Name = "Leather Robe",
                    RequiredLevel = 1,
                    Slot = Slot.Body,
                    Type = ArmourType.Cloth,
                    ArmourAttributes = new PrimaryAttributes() { Vitality = 1, Intelligence = 5 }
                });
                return InventoryChest;
            }           
        }
    }
  
}
