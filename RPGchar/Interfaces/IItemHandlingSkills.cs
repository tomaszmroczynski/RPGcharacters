using RPGchar.Items.Armour;
using RPGchar.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Interfaces
{
    interface IItemHandlingSkills
    {
        List<WeaponType> WeaponHandlingSkills();

        List<ArmourType> ArmourWearingSkills();
    }
}
