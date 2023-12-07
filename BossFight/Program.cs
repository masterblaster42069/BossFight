using BossFight;
namespace BossFight
{
    public class Game
    { 
        public void Start()
        {
            GameCharacter Hero = new GameCharacter(100, 20, 40);
            GameCharacter Boss = new GameCharacter(400, 30, 10);

            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Recharge");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Hero.Fight();
                Boss.Fight();
            }
        }    
    } 
} 



