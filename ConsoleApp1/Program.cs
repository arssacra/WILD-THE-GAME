using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WILD_THE_GAME.Weapon.Magazine.Interfaces;
using WILD_THE_GAME.Weapon.Magazine.Abstract;
using WILD_THE_GAME.Weapon.Ammo.Interfaces;
using WILD_THE_GAME.Weapon.Ammo.Abstract;

namespace WILD_THE_GAME.Player.Player
{
    class Ammo_9x18 : Ammo
    {
        string name;
        string type;
        int damage;
        int quality;
        public override string Name { get => name; set => name = value; }
        public override string Type { get => type; set => type = value; }
        public override int Damage { get => damage; set => damage = value; }
        public override int Quality { get => quality; set => quality = value; }

        public Ammo_9x18(string name = "9x18", string type = "9x18", int damage = 33, int quality = 100)
        {
            this.name = name;
            this.type = type;
            this.damage = damage;
            this.quality = quality;
        }
    }

    class Magazine_9x18 : Magazine
    {
        string name;
        List<IAmmo> supportedAmmo;
        IAmmo loadedAmmo;
        int maxBulletCount;
        int bulletCount;
        public override string Name { get => name; set => name = value; }
        public override List<IAmmo> SupportedAmmo { get => supportedAmmo; set => supportedAmmo = value; }
        public override IAmmo LoadedAmmo { get => loadedAmmo; set => loadedAmmo = value; }
        public override int MaxBulletCount { get => maxBulletCount; set => maxBulletCount = value; }
        public override int BulletCount { get => bulletCount; set => bulletCount = value; }
        public Magazine_9x18(List<IAmmo> supportedAmmo, IAmmo loadedAmmo, string name = "9x18", int maxBulletCount = 20, int bulletCount = 20)
        {
            this.name = name;
            this.maxBulletCount = maxBulletCount;
            this.bulletCount = bulletCount;
            this.loadedAmmo = loadedAmmo;
            this.supportedAmmo = supportedAmmo;
        }
    }

    class Makarov : GunshotWeapon
    {
        string name;
        int damage;
        IMagazine magazine;

        public override string Name { get => name; set => name = value; }
        public override int Damage { get => damage; set => damage = value; }
        public override IMagazine Magazine { get => magazine; set => magazine = value; }

        public Makarov(IMagazine magazine, string name = "Makarov", int damage = 11)
        {
            this.name = name;
            this.damage = damage;
            this.magazine = magazine;
        }

        public override void Fire(Player player)
        {
            player.ShowHealth();
            this.Magazine.BulletCount--;
            Console.WriteLine("BANG!");
            player.GetDamage(this.Damage);
            player.ShowHealth();
        }

        public override void Reload(IMagazine magazine)
        {
            
        }

        public override void ShowBulletCount()
        {
            Console.WriteLine("Bullets left: " + this.Magazine.BulletCount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Player john = new Player("Johny");

            Ammo_9x18 ammo_9x18 = new Ammo_9x18();

            List<IAmmo> supportedAmmo = new List<IAmmo>();

            supportedAmmo.Add(ammo_9x18);

            Magazine_9x18 makar_9x18 = new Magazine_9x18(supportedAmmo, ammo_9x18);

            Makarov makar = new Makarov(makar_9x18);

            makar.Fire(john);

            Console.ReadLine();
        }
    }
}
