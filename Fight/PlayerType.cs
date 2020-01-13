using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class PlayerType
    {

        private Player cow = new Player
        {
            Name = "Cow",
            Health = 20,
            Attack = 5,
            Defence = 1,
            SpecialRecharge = 100
        };

        private Player boxer = new Player
        {
            Name = "Boxer",
            Health = 50,
            Attack = 20,
            Defence = 2,
            SpecialRecharge = 100
        };

        private Player salmon = new Player
        {
            Name = "Salmon",
            Health = 10,
            Attack = 2,
            Defence = 0,
            SpecialRecharge = 100
        };

        private Player dragon = new Player
        {
            Name = "Dragon",
            Health = 100,
            Attack = 20,
            Defence = 10,
            SpecialRecharge = 100
        };

        public Player SetEnemy(string selected)
        {
            string lowercaseString = selected.ToLower();
            switch (lowercaseString)
            {
                case "1":
                case "cow":
                    return cow;
                case "2":
                case "boxer":
                    return boxer;
                case "3":
                case "salmon":
                    return salmon;
                case "4":
                case "dragon":
                    return dragon;
                default:
                    return salmon;
            }
        }
    }
}
