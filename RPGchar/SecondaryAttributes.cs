using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public struct SecondaryAttributes
    {
        public int Health { get; set; }  
        public int ArmorRating { get; set; }

        public int ElementalResistance { get; set; }

        public static SecondaryAttributes operator +(SecondaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new SecondaryAttributes
            {
                Health = lhs.Vitality + rhs.Vitality * 10,
                ArmorRating = lhs.Strength + rhs.Strength + lhs.Dexterity + rhs.Dexterity,
                ElementalResistance = lhs.Intelligence + rhs.Intelligence
            };
        }
    }
}
