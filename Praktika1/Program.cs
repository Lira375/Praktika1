using System;

namespace Praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            string world = "world";
            Console.WriteLine(hello + ", " + world);
            Console.WriteLine();


            int number1 = 12;
            int number2 = 7;
            Console.WriteLine("Сложение - " + (number1 + number2));
            Console.WriteLine("Вычитание - " + (number1 - number2));
            Console.WriteLine("Умножение - " + (number1 * number2));
            Console.WriteLine("Деление - " + (number1 / number2));
            Console.WriteLine();


            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string patronymic = Console.ReadLine();
            Console.WriteLine(surname + " " + name + " " + patronymic);
            Console.WriteLine();

            Random rand = new Random();
            int health_play = 150;
            int shield_play = 20;
            int health_monst = 180;
            int shield_monst = 15;
           
            do
            {
                 int damage_done;
                int damage_play = rand.Next(35, 80);
                damage_done = damage_play / shield_monst;
                    health_monst = health_monst - damage_done;
                if (health_monst > 0 || health_play > 0)
                {
                    Console.WriteLine("Здоровье монстра - " + health_monst);
                    Console.WriteLine("Игрок нанес урон - " + damage_done);
                }
                else { break; }

                int damage_monst = rand.Next(30, 70);
                int damage_done1;
                    damage_done1 = damage_monst / shield_play;
                    health_play = health_play - damage_done1;
                if (health_monst > 0 || health_play > 0)
                {
                    Console.WriteLine("Здоровье игрока - " + health_play);
                    Console.WriteLine("Монстр нанес урон - " + damage_done1);
                }
                else { break; }

            }
            while (health_monst >= 0 || health_play >= 0);



        }
    }
}
