using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes.Attributes
{
    public struct SecondaryAttributes
    {
        public int Health { get; set; }  
        public int ArmourRating { get; set; }

        public int ElementalResistance { get; set; }

        public static SecondaryAttributes operator +(SecondaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new SecondaryAttributes
            {
                Health =   rhs.Vitality * 10,
                ArmourRating =  rhs.Strength  + rhs.Dexterity,
                ElementalResistance =   rhs.Intelligence,
            };
        }
    }
}
