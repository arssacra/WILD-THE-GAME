using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILD_THE_GAME.Player.Stats.Abstract
{
    class BaseStats : Stats
    {
        string name;
        int max_health;
        int health;
        int stamina;
        int max_stamina;

        public override string Name { get => name; set => name = value; }
        public override int Max_health { get => max_health; set => max_health = value; }
        public override int Health { get => health; set => health = value > health ? max_health : value < 0 ? 0 : value; }
        public override int Stamina { get => stamina; set => stamina = value > max_stamina ? max_stamina : value < 0 ? 0 : value; }
        public override int Max_stamina { get => max_stamina; set => max_stamina = value; }
        public BaseStats(string name = "Player", int max_health = 100, int health = 100, int stamina = 100, int max_stamina = 100)
        {
            this.name = name;
            this.max_health = max_health;
            this.health = health;
            this.stamina = stamina;
            this.max_stamina = max_stamina;
        }

    }
}
