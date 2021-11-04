using RPGchar.Heroes.Attributes;
using RPGchar.Items.ArmourClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.ArmourClasses
{
    public class TestArmours
    {


        public Armour gothicPlate = new Armour()
        {
            Name = "Gothic Plate",
            RequiredLevel = 2,
            Slot = Slot.Body,
            Type = ArmourType.Plate,
            ArmourAttributes = new PrimaryAttributes() { Vitality = 10, Strength = 3 }
        };
        public Armour leatherRobe = new Armour()
        {
            Name = "Leather Robe",
            RequiredLevel = 1,
            Slot = Slot.Body,
            Type = ArmourType.Cloth,
            ArmourAttributes = new PrimaryAttributes() { Vitality = 1, Intelligence = 5 }
        };
    }
}

