using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossFight;
using static System.Net.Mime.MediaTypeNames;

namespace BossFight
{
    internal class GameCharacter
    {


        public string Name;
        public int Health;
        public int Strength;
        public int Stamina;
        private int maxStam;
       

        public GameCharacter(string name, int health, int strength, int stamina)
        { 
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            maxStam = stamina;
 
        }

        public void Fight(GameCharacter opponent)
        {
            Random random = new Random();
            int bossDamage = random.Next(31);

            if (Stamina == 0)
            {
                Console.WriteLine("Recharge first");
            }
            else
            {
                int damage = Math.Min(Strength, opponent.Health);
                opponent.Health -= damage;

                Console.WriteLine($"{Name} hit {opponent.Name} with {damage} damage, " +
                                  $"{opponent.Name} now has {opponent.Health} health left.");

                Stamina -= 10;

               
            }
        }

        public void Recharge()
        {
            Stamina = maxStam;
            Console.WriteLine($"{Name} is Recharging, they can still be attacked");
        }
    }
}
