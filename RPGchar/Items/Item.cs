﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items
{
    public abstract class Item
    {
        public string Name { get; set; }

        public int RequiredLevel { get; set; }

        public Slot Slot { get; set; }

        

    }
}