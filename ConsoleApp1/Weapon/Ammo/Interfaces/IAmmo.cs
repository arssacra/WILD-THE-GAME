using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILD_THE_GAME.Weapon.Ammo.Interfaces
{
    interface IAmmo
    {
        string Name { get; set; }
        string Type { get; set; } //9x18 or smthng same
        int Damage { get; set; }
        int Quality { get; set; }
    }
}
