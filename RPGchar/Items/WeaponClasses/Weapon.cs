using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.WeaponClasses
{   
    /// <summary>
    /// A class that represents weapons
    /// </summary>
    public class Weapon : Item

    {
        public WeaponType Type { get; set; }

        public WeaponAttributes WeaponAttributes { get; set; }
    }
}
