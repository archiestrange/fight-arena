using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Player
    {

        string name;
        int health;
        int attack;
        int defence;
        int defendDuration;
        int specialRecharge;
        int specialPower;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        public int DefendDuration
        {
            get { return defendDuration;  }
            set { defendDuration = value; }
        }

        public int SpecialRecharge
        {
            get { return specialRecharge; }
            set { specialRecharge = value; }
        }

        public int SpecialPower
        {
            get { return specialPower; }
            set { specialPower = value; }
        }

    }
}
