using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.WeaponClasses
{
    public class Weapon : Item
    //Name = "King Axe of Haste",
    //    RequiredLevel = 3,
    //    Slot = Slot.Weapon,
    //    Type = WeaponType.Axe,
    //    WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 2 }
    {

        public WeaponType Type { get; set; }

        public WeaponAttributes WeaponAttributes { get; set; }
    }
}
