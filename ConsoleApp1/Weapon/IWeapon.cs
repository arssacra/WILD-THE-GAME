using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WILD_THE_GAME.Player.Player;

interface IWeapon
{
    string Name { get; set; }
    int Damage { get; set; }
    void Fire(Player player);//TODO:
}
