using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME.Weapon.Magazine;
using WILD_THE_GAME.Weapon.Weapon.Gunshot.Interfaces;
using WILD_THE_GAME.Weapon.Magazine.Interfaces;

namespace WILD_THE_GAME.Player.Player
{
    abstract class GunshotWeapon : IGunshot
    {
        public abstract IMagazine Magazine { get; set; }
        public abstract string Name { get; set; }
        public abstract int Damage { get; set; }

        public abstract void Fire(Player player);
        public abstract void Reload(IMagazine magazine);
        public abstract void ShowBulletCount();
    }
}
