using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public abstract class Hero  // need to rebuild this is 

    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public int Level { get; set; }

        public Dictionary<Slot,Item> Equipment { get; set; }

        public abstract void EquipWeapon(Hero name, WeaponType type);

        public abstract void EquipArmor(Hero name, ArmorType type);





    }
}

