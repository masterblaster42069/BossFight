using BossFight;
namespace BossFight
{
    public class Game
    { 
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
        public void Start()
        {
            Random random = new Random();
            
            GameCharacter Hero = new GameCharacter("Hero",100, 20, 40);
            GameCharacter Boss = new GameCharacter("Boss",400, 0, 10);

            while (Hero.Health > 0 && Boss.Health > 0)
            {
                Boss.Strength = random.Next(31);
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Recharge");
                var input = Console.ReadLine();

                if (Boss.Stamina == 0)
                {
                    Boss.Recharge();
                }
                else
                {
                    Boss.Fight(Hero);
                }

                if (input == "1")
                {
                    Hero.Fight(Boss);

                    if (Boss.Health < 0) 
                    {
                        Boss.Fight(Hero);
                    }
                }
                else if (input == "2")
                {
                    if (Boss.Stamina == 0)
                    {
                        Boss.Recharge();
                        Console.WriteLine($"{Boss.Name} is recharging stamina.");
                    }
                    else
                    {
                        Boss.Fight(Hero);
                    }

                    Hero.Recharge();
                }
            }
            if (Hero.Health < 0)
                {
                Console.WriteLine("Hero is the Winner!");
                }
            else
                {
                Console.WriteLine("Boss Won");
                }
        }
    } 
} 



