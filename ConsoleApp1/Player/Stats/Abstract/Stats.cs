using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILD_THE_GAME.Player.Stats.Abstract
{
    abstract class Stats
    {
        public abstract string Name { get; set; }
        public abstract int Max_health { get; set; }
        public abstract int Health { get; set; }
        public abstract int Stamina { get; set; }
        public abstract int Max_stamina { get; set; }
    }
}
