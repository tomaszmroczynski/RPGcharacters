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
        /// <summary>
        /// A method prepared for furtre game development that starts or ends game
        /// </summary>
        /// <param name="input">User choice</param>
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
                Thread.Sleep(1000);
                input = "exit";
            }
        }



        /// <summary>
        /// Object that stores heroes found equipment made for future fun
        /// </summary>
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
