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



        static void Main(string[] args)
        {

            Game game = new Game();



            while (UserInput != "exit")
            {
                Console.WriteLine("Wouldyou like to start New Game?");
                
                Console.WriteLine("1. Yes");
                Thread.Sleep(1000);
                Console.WriteLine("2. No ");
                UserInput = Console.ReadLine();

                game.StartGame(UserInput);

                Console.WriteLine($"you wake up in an unlit room,"); 
                Thread.Sleep(2000);
                Console.WriteLine(" you do not remember anything,");
                Thread.Sleep(2000);
                Console.WriteLine(" how you found yourself here,");
                Thread.Sleep(2000);
                Console.WriteLine(" you feel a terrible headache.");
                Thread.Sleep(2000);
                Console.WriteLine(" You are trying to remind your who you are and your name.");
                Thread.Sleep(2000);
                Console.WriteLine(" try remind who you are");
                Console.WriteLine("1. remind your identity");
                Console.WriteLine("2. Exit");
                UserInput = Console.ReadLine();
                Hero hero;
                if(UserInput == "1")
                {
                    hero = new Mage();
                }
                else
                {
                    hero = new Warrior();
                }

                //var hero = game.NewHero(UserInput);
                
                hero.ShowCurrentAttributesStats(hero.);
                string s = "";

                Console.WriteLine("what is my name, how it was?");
                UserInput = Console.ReadLine();
                hero.RemindName(UserInput);
                

                //hero.PickUpItems(temporaryItems);

                hero.ShowBackPack(hero.BackPack);

                //hero.LevelUp();


            }




        }

        


     }
}

