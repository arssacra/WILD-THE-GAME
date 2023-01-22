using WILD_THE_GAME.Weapon.Magazine.Interfaces;
using WILD_THE_GAME.Weapon;
using WILD_THE_GAME.Player.Player;

namespace WILD_THE_GAME.Weapon.Weapon.Gunshot.Interfaces
{
    interface IGunshot : IWeapon
    {
        IMagazine Magazine { get; set; }
        void Reload(IMagazine magazine);
        void ShowBulletCount();
    }
}
