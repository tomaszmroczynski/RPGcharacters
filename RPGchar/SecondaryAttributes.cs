using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public struct SecondaryAttributes
    {
        public int Strength { get; set; }  //warning hat to be modified
        public int Intelligence { get; set; } //warning hat to be modified

        public static SecondaryAttributes operator +(SecondaryAttributes lhs, SecondaryAttributes rhs)
        {
            return new SecondaryAttributes
            {
                Intelligence = lhs.Intelligence + rhs.Intelligence, //warning hat to be modified
                Strength = lhs.Strength + rhs.Strength //warning hat to be modified
            };
        }
    }
}
