using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.ArmourClasses
{
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException(string message) : base(message)
        {
            
        }
    }
}
