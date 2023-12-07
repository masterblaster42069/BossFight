using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossFight;

namespace BossFight
{
    internal class GameCharacter
    {
        public int Health;
        public int Strenght;
        public int Stamina;
        private int maxStam;

        public GameCharacter(int health, int strenght, int stamina)
        {
            Health = health;
            Strenght = strenght;
            Stamina = stamina;
            maxStam = stamina;
        }

        public void Fight()
        {
            Stamina -= 10;
        }

        public void Recharge()
        {
            Stamina = maxStam;
        }
    }
}
