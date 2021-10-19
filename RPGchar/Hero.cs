using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public abstract class Hero  // need to rebuild this is 

    {

        public Hero()
        {
            Level = 1;
            Console.WriteLine("Give Your hero a name");
            Name = Console.ReadLine();
            Equipment = new Dictionary<Slot, Item>();
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

 



        public int Level { get; set; }

        public Dictionary<Slot,Item> Equipment { get; set; }

        public abstract void EquipWeapon( Weapon weapon);

        public abstract void EquipArmor( Armor armor, Slot slot);

        public abstract void LevelUp();





    }
}

