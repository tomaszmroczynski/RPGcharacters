using System;
using System.Collections.Generic;
namespace RPGchar
{
    class Program
    {
        static void Main(string[] args)
        {

            var values = Enum.GetValues(typeof(CharClasses));
            Console.WriteLine("Pick your class from list bellow and type it");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            string choice = Console.ReadLine();
            
          


            Console.WriteLine("type name of ");


            //mage.Equipment = new Dictionary<Slot, Item>();
            //mage.Equipment.Add(Slot.Weapon, new Weapon());
        }
        public void PickHeroClass(string choice)
        {

            Hero hero = choice == "Mage" ? new Mage() : choice == "Warrior" ? new Warrior() : choice == "Rogue" ? new Rogue() : choice == "Ranger" ? new Ranger() : default;



         }

     }
}

