using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME.Weapon.Ammo;
using WILD_THE_GAME.Weapon.Ammo.Interfaces;
using WILD_THE_GAME.Weapon.Magazine.Interfaces;

namespace WILD_THE_GAME.Weapon.Magazine.Abstract
{
    abstract class Magazine : IMagazine
    {
        public abstract string Name { get; set; }
        public abstract List<IAmmo> SupportedAmmo { get; set; }
        public abstract IAmmo LoadedAmmo { get; set; }
        public abstract int MaxBulletCount { get; set; }
        public abstract int BulletCount { get; set; }
    }
}
