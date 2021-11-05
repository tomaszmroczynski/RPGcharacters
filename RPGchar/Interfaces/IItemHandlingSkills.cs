
using RPGchar.Items.ArmourClasses;
using RPGchar.Items.WeaponClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Interfaces
{
    /// <summary>
    /// An interface for implementation of itemhandling skills methods
    /// </summary>
    interface IItemHandlingSkills
    {
        List<WeaponType> WeaponHandlingSkills();

        List<ArmourType> ArmourWearingSkills();
    }
}
