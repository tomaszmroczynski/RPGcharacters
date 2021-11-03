using RPGchar.Heroes.Attributes;
using RPGchar.Interfaces;
using RPGchar.Items;
using RPGchar.Items.Armour;
using RPGchar.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes
{
    public abstract class Hero : IItemHandlingSkills

    {

        public string Name { get; init; }

        public int Level { get; set; } = 1;

        public CharClasses HeroClass { get; init; }

        public PrimaryAttributes BasePrimaryAttributes { get;  set; } /// where is it

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
                double baseAttackAttribute = TotalPrimaryAttributes.Strength;
                    switch (this.HeroClass)
                {
                    case CharClasses.Mage:
                        baseAttackAttribute = TotalPrimaryAttributes.Intelligence;
                        break;
                    case CharClasses.Warrior:
                        baseAttackAttribute = TotalPrimaryAttributes.Strength;
                        break;
                        
                    case CharClasses.Rogue:
                        baseAttackAttribute = TotalPrimaryAttributes.Dexterity;
                        break;
                    case CharClasses.Ranger:
                        baseAttackAttribute = TotalPrimaryAttributes.Dexterity;
                        break;
                    default:
                        break;
                };
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
                double dps = attributes.Select(x => x.DPS).Sum();
                double value = baseAttackAttribute / 100.0;
                return dps * (1 + value);
            }
        }

        public Dictionary<Slot, Item> Equipment { get; set; } = new Dictionary<Slot, Item>();

        public void ShowCurrentAttributesStats(PrimaryAttributes attributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your current atributes are:");
            sb.AppendLine($"Strength: {attributes.Strength}");
            sb.AppendLine($"Dexterity: {attributes.Dexterity}");
            sb.AppendLine($"Intelligence: {attributes.Intelligence}");
            sb.AppendLine($"Vitality: {attributes.Vitality}");
            Console.WriteLine(sb.ToString());
        }
        public abstract List<WeaponType> WeaponHandlingSkills();

        public virtual void EquipWeapon(Weapon weapon) 
        {
            if (!WeaponHandlingSkills().Contains(weapon.Type))
            {
                throw new InvalidWeaponException($"Wrong wepon slot");
            }
            else if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"Too high weapon level");
            }
            else
            {
                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine($"What great {weapon.Type} u have equiped ");
            }
        }

        public abstract List<ArmourType> ArmourWearingSkills();

        public virtual void EquipArmour(Armour armour, Slot slot) {
            {
                if (!ArmourWearingSkills().Contains(armour.Type))
                    throw new InvalidArmourExeption("wrong armor type for your hero class");
                else if (armour.RequiredLevel > Level)
                    throw new InvalidArmourExeption("too low character level");
                else if (slot == Slot.Weapon)
                    throw new InvalidItemException("wrong item slot");
                else
                {
                    Equipment.Add(slot, armour);
                    Console.WriteLine($"What great {armour.Type} u have equiped ");
                }
            }
        }

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

        public List<Item> BackPack { get; set; } = new List<Item>();

       

       

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

