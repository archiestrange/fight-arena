using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    class PerformAction
    {
        private void Attack(Player attacker, Player defender)
        {
            Random rnd = new Random();
            double damage = rnd.Next(0, attacker.Attack);
            if (damage > 1 && defender.DefendDuration > 0)
            {
                damage = damage / 2;
                defender.DefendDuration = defender.DefendDuration - 1;
                Console.WriteLine($"{defender.Name} blocks half the incoming damage!");
            }
            Console.WriteLine($"{attacker.Name} hits for {damage} damage!");
            defender.Health = defender.Health - (int)Math.Round(damage);
        }

        private void Defend(Player attacker, Player defender)
        {
            attacker.DefendDuration = attacker.Defence;
        }

        private void Special(Player attacker, Player defender)
        {
            if (attacker.SpecialRecharge > 99)
            {
                attacker.Health = attacker.Health + attacker.SpecialPower;
                attacker.SpecialRecharge = 0;
                Console.WriteLine($"{attacker.Name} health for 5hp");
            }
        }

        public void Action(ActionType actionType, Player attacker, Player defender)
        {
            switch (actionType)
            {
                case ActionType.Attack:
                    Attack(attacker, defender);
                    break;
                case ActionType.Defend:
                    Defend(attacker, defender);
                    break;
                case ActionType.Special:
                    Special(attacker, defender);
                    break;
            }
        }
    }
}
