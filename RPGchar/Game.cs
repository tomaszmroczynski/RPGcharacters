using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Game
    {
        public Game()
        {
           Hero hero=  NewHero();

        }

       
   

        public Hero NewHero()
        {
            var values = Enum.GetValues(typeof(CharClasses));
            Console.WriteLine("Pick your hero class from list bellow and type it");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            string choice = Console.ReadLine();

            Hero hero = choice == "Mage" ? new Mage() : choice == "Warrior" ? new Warrior() : choice == "Rogue" ? new Rogue() : choice == "Ranger" ? new Ranger() : default;

            Console.WriteLine($"You have picked up {hero} ");
            Console.WriteLine($"Welocome {hero.Name} yur actual level is {hero.Level} let the adventure begin");

           

            return hero;
        }


       

        




    }
}
