using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.WeaponClasses
{
    public class TestWeapons
    {
        public object doombringerSword = new Weapon()
        {
            Name = "Doombringer",
            RequiredLevel = 2,
            Slot = Slot.Weapon,
            Type = WeaponType.Sword,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };
        public object kingAxeOfHaste = new Weapon()
        {
            Name = "King Axe of Haste",
            RequiredLevel = 3,
            Slot = Slot.Weapon,
            Type = WeaponType.Axe,
            WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
        };
    }
}
