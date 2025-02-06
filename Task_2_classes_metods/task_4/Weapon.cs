using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4v2
{
    public class Weapon
    {
        public string Name;
        public int CountRound;
        public virtual string ShootText { get; } = "Выстрел";

        public Weapon()
        {
            Name = "Noname";
            CountRound = 0;
        }

        public Weapon(string Name, string ShootText)
        {
            this.Name = Name;
            this.ShootText = ShootText;
        }
        public virtual void Shot() { }
        public virtual void Reload() { }

    }
    public class Pistol : Weapon
    {
        const int MaxRoundPistol = 9;
        public override string ShootText => "Бах";

        public Pistol()
        {
            base.Name = "Пистолет";
            base.CountRound = MaxRoundPistol;
        }
        public override void Shot()
        {
            if (base.CountRound > 0)
            {
                base.CountRound--;
                Console.WriteLine($"{ShootText}! В магазине осталось {base.CountRound} патронов.");
            }
            else
            {
                Console.WriteLine("В магазине не осталось патронов!");
            }
        }

        public override void Reload()
        {
            Console.WriteLine($"Вы сбросили {base.CountRound} патронов.");
            base.CountRound = MaxRoundPistol;
            Console.WriteLine($"В магазине {base.CountRound} патронов. Магазин полный.");
        }
    }

    public class MachineGun : Weapon
    {
        const int MaxRoundMachineGun = 30;
        public override string ShootText => "Буньк>";
        public MachineGun()
        {
            base.Name = "Автомат";
            base.CountRound = MaxRoundMachineGun;
        }
        public override void Shot()
        {
            if (base.CountRound > 0)
            {
                base.CountRound--;
                Console.WriteLine($"{ShootText}! В магазине осталось {base.CountRound} патронов.");
            }
            else
            {
                Console.WriteLine("В магазине не осталось патронов!");
            }
        }

        public override void Reload()
        {
            Console.WriteLine($"Вы сбросили {base.CountRound} патронов.");
            base.CountRound = MaxRoundMachineGun;
            Console.WriteLine($"В магазине {base.CountRound} патронов. Магазин полный.");
        }
    }

    public class RPG : Weapon
    {
        private const int MaxRoundRPG = 1;
        public override string ShootText => "Бдыщь";
        public RPG()
        {
            base.Name = "Рогатка";
            base.CountRound = MaxRoundRPG;
        }
        public override void Shot()
        {
            if (base.CountRound > 0)
            {
                base.CountRound--;
                Console.WriteLine($"{ShootText}! В магазине осталось {base.CountRound} патронов.");
            }
            else
            {
                Console.WriteLine("В магазине не осталось патронов!");
            }
        }

        public override void Reload()
        {
            Console.WriteLine($"Вы сбросили {base.CountRound} патронов.");
            base.CountRound = MaxRoundRPG;
            Console.WriteLine($"В магазине {base.CountRound} патронов. Магазин полный.");
        }
        public class Slingshot : Weapon
        {
            private const int MaxRoundSlingshot = 1;
            public override string ShootText => "Пуньк";
            public Slingshot()
            {
                base.Name = "Рогатка";
                base.CountRound = MaxRoundSlingshot;
            }
            public override void Shot()
            {
                if (base.CountRound > 0)
                {
                    base.CountRound--;
                    Console.WriteLine($"{ShootText}! В магазине осталось {base.CountRound} патронов.");
                }
                else
                {
                    Console.WriteLine("В магазине не осталось патронов!");
                }
            }

            public override void Reload()
            {
                Console.WriteLine($"Вы сбросили {base.CountRound} патронов.");
                base.CountRound = MaxRoundSlingshot;
                Console.WriteLine($"В магазине {base.CountRound} патронов. Магазин полный.");
            }
        }
        public class WaterGun : Weapon
        {
            private const int MaxRoundWaterGun = 5;
            public override string ShootText => "Пшшшш";
            public WaterGun()
            {
                base.Name = "Рогатка";
                base.CountRound = MaxRoundWaterGun;
            }
            public override void Shot()
            {
                if (base.CountRound > 0)
                {
                    base.CountRound--;
                    Console.WriteLine($"{ShootText}! В магазине осталось {base.CountRound} патронов.");
                }
                else
                {
                    Console.WriteLine("В магазине не осталось патронов!");
                }
            }

            public override void Reload()
            {
                Console.WriteLine($"Вы сбросили {base.CountRound} патронов.");
                base.CountRound = MaxRoundWaterGun;
                Console.WriteLine($"В магазине {base.CountRound} патронов. Магазин полный.");
            }
        }
    }
}
