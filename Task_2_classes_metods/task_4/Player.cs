using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_4v2.RPG;

namespace Task_4v2
{
    internal class Player
    {
        public string Name;
        private Weapon[] weaponSlots;
        public Player()
        {
            weaponSlots = new Weapon[] {

                new Pistol(),
                new MachineGun(),
                new RPG(),
                new Slingshot(),
                new WaterGun()
                };
        }

        public int getSlotsCount()
        {
            return weaponSlots.Length;
        }
        public void shotWithWeapon(int slot)
        {
            if (slot >= weaponSlots.Length)
            {
                Console.WriteLine("Некорректный номер слота, выберите другое оружие");
                return;
            }
            Weapon weapon = weaponSlots[slot];
            weapon.Shot();
        }
        public void reloadWeapon(int slot)
        {
            if (slot >= weaponSlots.Length)
            {
                Console.WriteLine("Некорректный номер слота, выберите другое оружие");
                return;
            }
            Weapon weapon = weaponSlots[slot];
            weapon.Reload();
        }


    }
}
