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



        public  Hero NewHero(string input)
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
            return  input == "1" ? new Mage() : input == "2" ? new Warrior() : input == "3" ? new Rogue() : input == "4" ? new Ranger() : default; ;
        
        }    

            //var temporaryItems = new List<Item>();

            //temporaryItems.Add(new Weapon()
            //{
            //    Name = "Common axe",
            //    RequiredLevel = 1,
            //    Slot = Slot.Weapon,
            //    Type = WeaponType.Axe,
            //    WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            //});
            //temporaryItems.Add(new Weapon()
            //{
            //    Name = "Common bow",
            //    RequiredLevel = 1,
            //    Slot = Slot.Weapon,
            //    Type = WeaponType.Bow,
            //    WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            //});
            //temporaryItems.Add(new Armour()
            //{
            //    Name = "Common plate body Armour",
            //    RequiredLevel = 1,
            //    Slot = Slot.Body,
            //    Type = ArmourType.Plate,
            //    Attributes = new PrimaryAttributes() { Vitality = 2, Strength = 1 }
            //});
            //temporaryItems.Add(new Armour()
            //{
            //    Name = "Common cloth head armor",
            //    RequiredLevel = 1,
            //    Slot = Slot.Head,
            //    Type = ArmourType.Cloth,
            //    Attributes = new PrimaryAttributes() { Vitality = 1, Intelligence = 5 }
            //});

           


        }












    
}
