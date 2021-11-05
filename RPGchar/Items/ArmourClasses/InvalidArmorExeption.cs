using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.ArmourClasses
{
    /// <summary>
    /// A class used whenever armour is invaid
    /// </summary>
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException(string message) : base(message)
        {
            
        }
    }
}
