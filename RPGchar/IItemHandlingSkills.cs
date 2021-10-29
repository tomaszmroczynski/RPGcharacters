using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    interface IItemHandlingSkills
    {
        List<WeaponType> WeaponHandlingSkills();

        List<ArmourType> ArmourWearingSkills();
    }
}
