using RPGchar.Heroes.Attributes;
using RPGchar.Interfaces;
using RPGchar.Items;
using RPGchar.Items.ArmourClasses;
using RPGchar.Items.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes
{
    /// <summary>
    /// An abstract class holding shared methods, props , fields for child hero classes
    /// </summary>
    public abstract class Hero : IItemHandlingSkills
    {

        public string Name { get; init; }

        private int level = 1;

        public int Level
        {
            get { return level; }
            set
            {
                level = value < 1 ? throw new ArgumentException("Invalid character level !!!") : value;
            }
        }

        public CharClasses HeroClass { get; init; }

        public PrimaryAttributes BasePrimaryAttributes { get => GetCurrentAttributes(); }

        /// <summary>
        /// Calculation of TotalPrimaryAttributes from base attributes and all equipmet influence
        /// </summary>
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
            get { return GetSecondaryAttributes(); }
        }

        /// <summary>
        /// Method that calculate secondary attributes 
        /// </summary>
        /// <returns>Returns updated struct SecoundaryAttributes</returns>
        public SecondaryAttributes GetSecondaryAttributes()
        {
            SecondaryAttributes attr = new SecondaryAttributes();
            attr.ArmourRating = TotalPrimaryAttributes.Dexterity + TotalPrimaryAttributes.Strength;
            attr.Health = TotalPrimaryAttributes.Vitality * 10;
            attr.ElementalResistance = TotalPrimaryAttributes.Intelligence;
            return attr;
        }
        /// <summary>
        /// Caculation of hero damage per second 
        /// </summary>
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
                return dps ==0?(1 + value): dps * (1 + value);
            }
        }
        /// <summary>
        /// A prosperity for equiping weapons and armour.
        /// </summary>
        public Dictionary<Slot, Item> Equipment { get; set; } = new Dictionary<Slot, Item>();

        /// <summary>
        /// A method that shows actual hero PrimaryAtributes
        /// </summary>
        /// <param name="attributes">Can be base attributes or total</param>
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

        /// <summary>
        /// A method that shows actual hero Secondary Attributes
        /// </summary>
        /// <param name="attributes">Actual Secondary Attributes</param>
        public void ShowCurrentAttributesStats(SecondaryAttributes attributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Your current atributes are:");
            sb.AppendLine($"Strength: {attributes.Health}");
            sb.AppendLine($"Dexterity: {attributes.ArmourRating}");
            sb.AppendLine($"Intelligence: {attributes.ElementalResistance}");
            Console.WriteLine(sb.ToString());
        }
        public abstract List<WeaponType> WeaponHandlingSkills();

        /// <summary>
        /// Equips a hero in selected weapon
        /// </summary>
        /// <param name="weapon">Weapon to equip (An object of Weapon Class)</param>
        public virtual void EquipWeapon(Weapon weapon) 
        {
            if (!WeaponHandlingSkills().Contains(weapon.Type))
            {
                throw new InvalidWeaponException($"Invalid weapon type for your class");
            }
            else if (weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"Weapon level too high!");
            }
            else
            {
                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine("New weapon equiped!");
            }
        }

        public abstract List<ArmourType> ArmourWearingSkills();

        /// <summary>
        /// Equips hero in selected armour
        /// </summary>
        /// <param name="armour">An armour to be equipped </param>
        /// <param name="slot">A slot for selected armour </param>
        public virtual void EquipArmour(Armour armour, Slot slot) {
            {
                if (!ArmourWearingSkills().Contains(armour.Type))
                    throw new InvalidArmourException("Invalid armor type for your hero class");
                else if (armour.RequiredLevel > Level)
                    throw new InvalidArmourException("Armour level too high!");
                else if (slot == Slot.Weapon)
                    throw new InvalidItemException("wrong item slot");
                else
                {
                    Equipment.Add(slot, armour);
                    Console.WriteLine("New armour equiped!");
                }
            }
        }
        /// <summary>
        /// A method that levels up hero and updates current attributes 
        /// </summary>
        public abstract void LevelUp();


        /// <summary>
        /// A method that allows hero to pickup found equipment and place it in backpack for planned  future game development. 
        /// </summary>
        /// <param name="items">Found weapon or armour</param>
        public void PickUpItems(List<Item> items)
        {
            BackPack.AddRange(items);
            Console.WriteLine("you pickpup some interesting equipment");  
        }
        /// <summary>
        /// A method that that show inventory stored in backpack or other container for planned  future game development. 
        /// </summary>
        /// <param name="backpack">Backapack or other container storring pickuped weapons and armour</param>
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

        /// <summary>
        /// A method that gets summarised actual attribtes
        /// </summary>
        /// <returns>CurrentAttributes</returns>
        public abstract PrimaryAttributes GetCurrentAttributes();

       
        /// <summary>
        /// A method for planned  future game development that allow user to give hero name on innit.
        /// </summary>
        /// <param name="input">User choice of hero name </param>
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

