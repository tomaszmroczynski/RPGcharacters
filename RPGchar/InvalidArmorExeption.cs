using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public class InvalidArmorExeption : Exception
    {
        public InvalidArmorExeption(string message) : base(message)
        {
        }
    }
}
