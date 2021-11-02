using RPGchar.Heroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.Armour
{
    public class Armour : Item
    {
        public ArmourType Type { get; set; }

        public PrimaryAttributes ArmourAttributes { get; set; }


    }
}
