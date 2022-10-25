using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammo_System
{
    internal class Program
    {

        static string[] weapon;
        static int[] ammo;
        static int setwp;
        static int[] MAXammo;
        static int MINammo = 0;
        static int[] shots;

        static void Main(string[] args)
        {
            //how many bullets are substracted from the ammo
            shots=new int[5];
            shots[0] = 0;
            shots[1] = 1;
            shots[2] = 3;
            shots[3] = 1;
            shots[4] = 1;

            //name of weapon
            weapon = new string[5];
            weapon[0] = "None";
            weapon[1] = "Pistol";
            weapon[2] = "SMG";
            weapon[3] = "Shotgun";
            weapon[4] = "Machine Gun";

            //amount of bullets/shells left
            ammo = new int[5];
            ammo[0] = 0;
            ammo[1] = 12;
            ammo[2] = 30;
            ammo[3] = 2;
            ammo[4] = 24;

            //the maximum amount of ammo per weapon
            MAXammo = new int[5];
            MAXammo[0] = 0;
            MAXammo[1] = 12;
            MAXammo[2] = 30;
            MAXammo[3] = 2;
            MAXammo[4] = 24;

            ShowHUD();
            Console.WriteLine("Press any key to change your weapon");
            Console.ReadKey(true);


            Console.Clear();
            changeWP(1);
            ShowHUD();
            Console.WriteLine("Press any key to fire");
            Console.ReadKey(true);

            Console.Clear();
            Fire();
            ShowHUD();
            Console.WriteLine("Press any key to change your weapon");
            Console.ReadKey(true);

            Console.Clear();
            changeWP(2);
            ShowHUD();
            Console.WriteLine("Press any key to fire");
            Console.ReadKey(true);

            Console.Clear();
            Fire();
            ShowHUD();
            Console.WriteLine("Press any key to fire");
            Console.ReadKey();

            Console.Clear();
            Fire();
            ShowHUD();
            Console.WriteLine("Press any key to fire");
            Console.ReadKey();

            Console.Clear();
            Fire();
            ShowHUD();
            Console.WriteLine("Press any key to fire");
            Console.ReadKey();

            Console.Clear();
            Fire();
            ShowHUD();
            Console.WriteLine("Press any key to reload");
            Console.ReadKey();

            Console.Clear();
            Reload();
            Console.WriteLine("Press any key to end game");
            Console.ReadKey(true);

        }

        static void changeWP(int wp)
        {
            setwp = wp;
        }

        static void ShowHUD()
        {
            Console.WriteLine("Weapon: " + weapon[setwp]);
            Console.WriteLine("Ammo: " + ammo[setwp]);

        }

        static void Fire()
        {
            ammo[setwp] = ammo[setwp] - shots[setwp];
        }

        static void Reload()
        {
            ammo[setwp]=MAXammo[setwp];
            if (ammo[setwp] > MAXammo[setwp])
            {
                ammo[setwp] = MAXammo[setwp];
            }

            if (ammo[setwp] < MINammo)
            {
                ammo[setwp] = MINammo;
            }
        }

    }
}
