using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    public abstract class Hero  // personally I think it would be better to make hero as full class with virtual methods,
                                // but bacause of recomendation I keep as it is.

    {

        public Hero()
        {
            Level = 1;
            Console.WriteLine("Give Your hero a name");
            Name = Console.ReadLine();
            Equipment = new Dictionary<Slot, Item>();
        }
        public string Name { get; set; }

        public int Level { get; set; }

        public PrimaryAttributes BasePrimaryAttributes { get; set; }

        public PrimaryAttributes TotalPrimaryAttributes { get; set; }

        public SecondaryAttributes SecondaryAttributes { get; set; }
    
        public Dictionary<Slot,Item> Equipment { get; set; }

        public abstract void EquipWeapon( Weapon weapon);

        public abstract void EquipArmour( Armour armour, Slot slot);

        public abstract void LevelUp();

        public abstract void SearchChest();

        public List<Item> BackPack { get; set; }





    }
}

