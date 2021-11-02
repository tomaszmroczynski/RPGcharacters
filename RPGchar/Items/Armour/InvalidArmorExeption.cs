using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.Armour
{
    public class InvalidArmourExeption : Exception
    {
        public InvalidArmourExeption(string message) : base(message)
        {
            
        }
    }
}
