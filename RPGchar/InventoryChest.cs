using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class InventoryChest
    {
        public List<Item> ChestContent { get; set; }

        Weapon testAxe = new Weapon()
        {
            Name = "Common axe",
            RequiredLevel = 1,
            Slot = Slot.Weapon,
            Type = WeaponType.Axe,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };
        Weapon testBow = new Weapon()
        {
            Name = "Common bow",
            RequiredLevel = 1,
            Slot = Slot.Weapon,
            Type = WeaponType.Bow,
            WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
        };
        Armour testPlateBody = new Armour()
        {
            Name = "Common plate body Armour",
            RequiredLevel = 1,
            Slot = Slot.Body,
            Type = ArmourType.Plate,
            Attributes = new PrimaryAttributes() { Vitality = 2, Strength = 1 }
        };
        Armour testClothHead = new Armour()
        {
            Name = "Common cloth head armor",
            RequiredLevel = 1,
            Slot = Slot.Head,
            Type = ArmourType.Cloth,
            Attributes = new PrimaryAttributes() { Vitality = 1, Intelligence = 5 }
        };




    }
}
