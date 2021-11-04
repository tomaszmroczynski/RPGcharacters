using RPGchar.Heroes;
using RPGchar.Heroes.HeroeClasses;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RPGchar
{
    class Program 
    {
        public static string UserInput { get; set; }

        public static Hero NewHero(string input)
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

        static void Main(string[] args)
        {

            Game game = new Game();

            while (UserInput != "exit")
            {
                Console.WriteLine("Wouldyou like to start New Game?");
                
                Console.WriteLine("1. Yes");
                //Thread.Sleep(1000);
                Console.WriteLine("2. No ");
                UserInput = Console.ReadLine();

                game.StartGame(UserInput);

                Console.WriteLine($"you wake up in an unlit room,"); 
                //Thread.Sleep(2000);
                Console.WriteLine(" you do not remember anything,");
                //Thread.Sleep(2000);
                Console.WriteLine(" how you found yourself here,");
                //Thread.Sleep(2000);
                Console.WriteLine(" you feel a terrible headache.");
                //Thread.Sleep(2000);
                Console.WriteLine(" You are trying to remind your who you are and your name.");
                //Thread.Sleep(2000);
                Console.WriteLine(" try remind who you are");
                Console.WriteLine("1. remind your identity");
                Console.WriteLine("2. Exit");
                UserInput = Console.ReadLine();
                Hero hero;
                hero = NewHero(UserInput);
                var charaterDPS = hero.CharacterDPS;
                hero.LevelUp();
            

                Console.WriteLine("what is my name, how it was?");
                UserInput = Console.ReadLine();
                hero.RemindName(UserInput);
                

                

                hero.ShowBackPack(hero.BackPack);

             


            }




        }

        


     }
}

