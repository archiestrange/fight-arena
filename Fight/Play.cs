using System;

namespace Fight
{
    class Play
    {
        int round = 1;
        private int Round
        {
            get { return round; }
            set { round = value; }
        }

        public void StartGame(Player player)
        {
            EnterName(player);
            WelcomeMessage(player.Name);

            Player enemy = SelectEnemy();
            PerformAction performAction = new PerformAction();

            while (player.Health > 0)
            {
                Console.WriteLine($"-------- Round {round} --------");
                Console.WriteLine($"{player.Health} {player.Name} -- {enemy.Name} {enemy.Health}");
                ActionType actionType = SelectActionType(player);
                performAction.Action(actionType, player, enemy);
                performAction.Action(ActionType.Attack, enemy, player);
                Console.WriteLine();
                EndOfRound(player);
                EndOfRound(enemy);
                Round = Round + 1;

                if (enemy.Health < 1)
                {
                    enemy = EndOfFight(player, enemy);
                }
            }

            Console.WriteLine("Game Over! You have died.");
        }

        private void WelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome to the arena {name}");
            Console.WriteLine();
        }

        private void EnterName(Player player)
        {
            Console.WriteLine("Please enter a player name...");
            player.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private Player SelectEnemy()
        {
            Console.WriteLine("Select an enemy to fight...");
            Console.WriteLine("1 - Cow");
            Console.WriteLine("2 - Boxer");
            Console.WriteLine("3 - Salmon");
            Console.WriteLine("4 - Dragon");

            PlayerType playerType = new PlayerType();
            Player enemy = playerType.SetEnemy(Console.ReadLine());
            Console.WriteLine();

            return enemy;
        }

        private ActionType SelectActionType(Player player)
        {
            Console.WriteLine($"1 - Attack ({player.Attack})");
            Console.WriteLine($"2 - Defend ({player.Defence})");
            Console.WriteLine($"3 - Heal ({player.SpecialPower})");

            ActionType action = SetActionType(Console.ReadLine());
            Console.WriteLine();

            return action;
        }

        private ActionType SetActionType(string selected)
        {

            string lowercaseString = selected.ToLower();
            switch (lowercaseString)
            {
                case "1":
                case "attack":
                    return ActionType.Attack;
                case "2":
                case "defend":
                    return ActionType.Defend;
                case "3":
                case "special":
                    return ActionType.Special;
                default:
                    return ActionType.Attack;
            }
        }

        private Player EndOfFight(Player player, Player enemy)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"You killed {enemy.Name}!");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            LevelUp(player);
            Round = 1;
            player.SpecialRecharge = 100;
            return SelectEnemy();
        }

        private void SetLevelUp(string selected, Player player)
        {

            string lowercaseString = selected.ToLower();
            switch (lowercaseString)
            {
                case "1":
                case "attack":
                    player.Attack = player.Attack + 5;
                    break;
                case "2":
                case "defend":
                    player.Defence = player.Defence + 1;
                    break;
                case "3":
                case "special":
                    player.SpecialPower = player.SpecialPower + 5;
                    break;
                case "4":
                case "health":
                    player.Health = player.Health + 10;
                    break;
                default:
                    player.Attack = player.Attack + 5;
                    break;
            }
        }

        private void LevelUp(Player player)
        {
            Console.WriteLine("Level up a skill:");
            Console.WriteLine($"1 - Attack ({player.Attack})");
            Console.WriteLine($"2 - Defence ({player.Defence})");
            Console.WriteLine($"3 - Special ({player.SpecialPower})");
            Console.WriteLine($"4 - Health ({player.Health})");

            SetLevelUp(Console.ReadLine(), player);
            Console.WriteLine();

        }

        private void EndOfRound(Player player)
        {
            if(player.SpecialRecharge < 100)
                {
                player.SpecialRecharge = player.SpecialRecharge + 25;
            }
        }
    }
}
