using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Ranger : Hero
    {
        public override List<WeaponType> WeaponHandlingSkills()
        {
            return new List<WeaponType>() { WeaponType.Bow };
        }

        public override List<ArmourType> ArmourWearingSkills()
        {
            return new List<ArmourType>() { ArmourType.Leather, ArmourType.Mail };
        }

        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1 , Dexterity= 7, Vitality = 8 };
        
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1, Dexterity = 5, Vitality= 2 };

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
                var value = Convert.ToDouble(TotalPrimaryAttributes.Dexterity) / 100.0;
                return dps * (1 + value);
            }
        }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
            Console.WriteLine($"Congratulations {Name} You have leveled up, and your actual level is {Level} ");
            Console.WriteLine("Your updated atributes are:");
            Console.WriteLine($"Strength {currentAttributes.Strength}");
            Console.WriteLine($"Dexterity {currentAttributes.Dexterity}");
            Console.WriteLine($"Intelligence {currentAttributes.Intelligence}");
            Console.WriteLine($"Vitality {currentAttributes.Vitality}");
        }



        public override void SearchChest()
        {
            throw new NotImplementedException();
        }


    }
}

