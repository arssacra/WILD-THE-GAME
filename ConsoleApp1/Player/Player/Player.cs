using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME;
using WILD_THE_GAME.Player.Stats.Abstract;

namespace WILD_THE_GAME.Player.Player
{
    class Player
    {
        BaseStats stats;
        public Player(string name)
        {
            this.stats = new BaseStats(name);
        }

        public void ShowHealth()
        {
            Console.WriteLine(this.stats.Name + " health is " + this.stats.Health);
        }

        public Player GetDamage(int damage)
        {
            if (this.stats.Health - damage <= 0)
            {
                this.Death();
            }
            else
            {
                this.stats.Health -= damage;
            }
            return this;
        }

        public void Atack(Player player)
        {
            player.GetDamage(11);
        }

        void Death()
        {
            this.stats.Health = 0;
            Console.WriteLine(this.stats.Name + " is death...");
        }

    }
}