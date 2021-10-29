using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Mage : Hero
    {
        public override List<WeaponType> WeaponHandlingSkills() 
        {
            return new List<WeaponType>() { WeaponType.Staff, WeaponType.Wand }; 
        }
        public override List<ArmourType> ArmourWearingSkills() 
        { 
            return new List<ArmourType>() { ArmourType.Cloth };
        } 

        public PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 8, Dexterity = 1, Vitality = 5 };
  
        public readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 5, Dexterity = 1, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override double CharacterDPS
        {
            get
            {

                var allItems = Equipment.Select(x => x.Value).ToList();
                List<Weapon> allWeapons = new();
                foreach (var item in allItems)
                {
                    if (item is Weapon weapon)
                    {
                        allWeapons.Add(weapon);
                    }
                }
                var attributes = allWeapons.Select(x => x.WeaponAttributes).ToList();
                var dps = attributes.Select(x => x.DPS).Sum();
                var value = Convert.ToDouble(TotalPrimaryAttributes.Intelligence) / 100.0;
                return dps * (1 + value);
            }
        }

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




        public override void SearchChest()
        {
            
            



            
        }


    }
}
