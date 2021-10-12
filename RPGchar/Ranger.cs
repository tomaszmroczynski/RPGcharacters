using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
    class Ranger
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Vitality { get; set; }
        public int Health
        {
            get { return health; }
            set { health = vitality * 10 + value; }
        }

        public int ArmorRating
        {
            get { return armorRating; }
            set { armorRating = dexterity + strength + value; }
        }

        public int ElemetalResistance
        {
            get { return elementalResistance; }
            set { elementalResistance = Inteligence + value; }
        }



        public int DamageLevel
        {
            get { return damageLevel; }
            set { elementalResistance = inteligence; }
        }
    }
}
