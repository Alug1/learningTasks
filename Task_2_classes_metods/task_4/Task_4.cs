using System.Reflection.PortableExecutable;
using Task_4v2;


namespace Task_4v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerPlaying = "y";
            while (playerPlaying == "y")
            {
                Player player = new Player();
                Console.WriteLine("Список оружия: \n0) Пистолет \n1) Автомат \n2) RPG \n3) Рогатка \n4) Водяной пистолет");
                Console.WriteLine("Введите номер оружия, которое хотите использовать");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Что вы хотите? \n 1 - Выстрелить \n 2 - Перезарядить");
                Console.Write("Введине номер действия:");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        player.shotWithWeapon(choice);
                        break;

                    case 2:
                        player.reloadWeapon(choice);
                        break;

                }

            }
        }
    }
}