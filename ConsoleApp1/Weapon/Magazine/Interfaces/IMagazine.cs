using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME.Weapon.Ammo.Interfaces;

namespace WILD_THE_GAME.Weapon.Magazine.Interfaces
{
    interface IMagazine
    {
        string Name { get; set; }
        List<IAmmo> SupportedAmmo { get; set; } //Because magazine can support several bullet types (for example - trace, dum-dum, or smthng)
        IAmmo LoadedAmmo { get; set; } // Type of loaded ammo for now
        int MaxBulletCount { get; set; }
        int BulletCount { get; set; }
    }
}
