using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public abstract class Hero  

    {
        public Hero()
        {

            
            Equipment = new Dictionary<Slot, Item>();
            BackPack  = new List<Item>();
            
        }
        public string Name { get; init; }

        public int Level { get; set; } = 1;

        public CharClasses HeroClass { get; init; }

        public PrimaryAttributes BasePrimaryAttributes { get; private set; }

        public PrimaryAttributes TotalPrimaryAttributes
        {
            get
            {
                var allItems = Equipment.Select(x => x.Value).ToList();
                List<Armour> allArmour = new List<Armour>();
                foreach (var item in allItems)
                {
                    if (item is Armour)
                    {
                        allArmour.Add((Armour)item);
                    }
                }
                var allArmourAttributes = allArmour.Select(x => x.ArmourAttributes).ToList();
                PrimaryAttributes total = new PrimaryAttributes();
                foreach (var item in allArmourAttributes)
                {
                    total += item;
                }

                return BasePrimaryAttributes + total;
            }
        }

        public SecondaryAttributes SecondaryAttributes
        {
            get 
            {
                return SecondaryAttributes + TotalPrimaryAttributes;
            }
        }

        public virtual double CharacterDPS 

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
                var value = Convert.ToDouble(TotalPrimaryAttributes.Strength) / 100.0;
                return dps * (1 + value);
            }
        }
        public Dictionary<Slot,Item> Equipment { get; set; }

        public abstract void EquipWeapon(Weapon weapon);

        public abstract void EquipArmour(Armour armour, Slot slot);

        public abstract void LevelUp();

        public abstract void SearchChest();

        public void PickUpItems(List<Item> items)
        {
            BackPack.AddRange(items);
            Console.WriteLine("you pickpup some interesting equipment");  
        }

        public void ShowBackPack(List<Item> backpack)
        {
            StringBuilder itemList = new StringBuilder();
            itemList.AppendLine($" Your Backpack contains following items");
            int idx = 1;
            foreach (var item in backpack)
            { 
                itemList.AppendLine($"{idx} {item.Name} with required level  {item.RequiredLevel} ");
                idx++;
            }
            Console.WriteLine(itemList.ToString());
        }

        public List<Item> BackPack { get; set; }

        public void RemindName(string input)
        {
            
            Console.WriteLine($"{input[0]}.....");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"{input[0]}{input[1]}.....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"oh my head.... {input}.....yes thats it");
        }



    }
}

