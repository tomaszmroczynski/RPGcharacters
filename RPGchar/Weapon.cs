using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class Weapon : Item
    {
        public WeaponType Type { get; set; }

        public int Damage { get; set; }

        public int AttackSpeed { get; set; }

        public int CorrectSlot{ get; set; } //

        public int DPS
        {
            get { return Damage * AttackSpeed; }
        }
    }
}
