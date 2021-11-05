using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Heroes.Attributes
{
    /// <summary>
    /// A custom type representing heroes atributes
    /// </summary>
    public struct PrimaryAttributes 
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public int Dexterity { get; set; }

        public int Vitality { get; set; }

        /// <summary>
        /// A static method with overloaded opertor + for addtion two instances of PrimaryAttributes
        /// </summary>
        /// <param name="lhs">left hand side PrimaryAttributes instance</param>
        /// <param name="rhs">right hand side PrimaryAttributes instance</param>
        /// <returns></returns>
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes
            {
                Intelligence = lhs.Intelligence + rhs.Intelligence,
                Strength = lhs.Strength + rhs.Strength,
                Dexterity = lhs.Dexterity + rhs.Dexterity,
                Vitality = lhs.Vitality +rhs.Vitality
            };
        }




    }
}
