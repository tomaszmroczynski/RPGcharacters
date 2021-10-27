using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Rogue : Hero
    {
        private readonly List<WeaponType> WeaponHandlingSkills = new List<WeaponType>() { WeaponType.Dagger, WeaponType.Sword };

        private readonly List<ArmourType> ArmourWearingSkills = new List<ArmourType>() { ArmourType.Leather, ArmourType.Mail };

        private PrimaryAttributes currentAttributes = new PrimaryAttributes { Strength = 2, Intelligence = 1, Dexterity = 6, Vitality = 8 };
        
        private readonly PrimaryAttributes gainedAttributes = new PrimaryAttributes { Strength = 1, Intelligence = 1, Dexterity = 4, Vitality = 3 };

        public PrimaryAttributes CurrentAttributes { get => currentAttributes; }

        public override void LevelUp()
        {
            currentAttributes = currentAttributes + gainedAttributes;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (!WeaponHandlingSkills.Contains(weapon.Type))
                throw new InvalidWeaponException($"Wrong type of weapon");
            else if (weapon.RequiredLevel > Level)
                throw new InvalidWeaponException($"{weapon.Name}{weapon.Type} required level  is too high to use it right now");
            else
            {
                Equipment.Add(Slot.Weapon, weapon);
                Console.WriteLine($"What great {weapon.Type} u have equiped ");
            }
        }

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

        public override void SearchChest()
        {
            throw new NotImplementedException();
        }

        public override void EquipArmour(Armour armour, Slot slot)
        {
            if (!ArmourWearingSkills.Contains(armour.Type))
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
}
