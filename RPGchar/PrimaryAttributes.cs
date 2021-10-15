using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public struct PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes
            {
                Intelligence = lhs.Intelligence + rhs.Intelligence,
                Strength = lhs.Strength + rhs.Strength
            };
        }
    }
}
