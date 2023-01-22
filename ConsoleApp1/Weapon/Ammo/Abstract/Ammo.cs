using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME.Weapon.Ammo.Interfaces;

namespace WILD_THE_GAME.Weapon.Ammo.Abstract
{
    abstract class Ammo : IAmmo
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract int Damage { get; set; }
        public abstract int Quality { get; set; }
    }
}
