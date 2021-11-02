using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.Weapon
{
    public class WeaponAttributes
    {
        public double Damage { get; set; }

        public double AttackSpeed { get; set; }

        public double DPS
        {
            get { return Damage * AttackSpeed; }
        }
    }
}
