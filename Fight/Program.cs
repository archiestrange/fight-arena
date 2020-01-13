using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerOne = new Player
            {
                Health = 100,
                Attack = 10,
                Defence = 2,
                SpecialRecharge = 100,
                SpecialPower = 5
            };

            var Enemy = new Player { };
            Play play = new Play();
            play.StartGame(PlayerOne);
        }

    }
}
