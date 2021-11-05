using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items
{
    /// <summary>
    /// An abstract class that holds shared weapon/armour prosperities
    /// </summary>
    public abstract class Item
    {
        public string Name { get; set; }

        public int RequiredLevel { get; set; }

        public Slot Slot { get; set; }

    }
}
