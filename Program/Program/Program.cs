using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2:34 :09 / 9:19:55
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //player1
            float health1 = rand.Next(90, 100);
            int damage1 = rand.Next(30, 60);
            int armor1 = rand.Next(65, 100);
            //player2
            float health2 = rand.Next(80, 150);
            int damage2 = rand.Next(20, 40);
            int armor2 = rand.Next(65, 100);


            Console.WriteLine($"Gladiator 1 - {health1} здоровье {damage1}  урон {armor1}");
            Console.WriteLine($"Gladiator 2  - {health2} здоровье {damage2}  урон {armor2}");


            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
                Console.WriteLine("Здоровье гладиатора 1:  " + health1);
                Console.WriteLine("Здоровье гладиатора 2:  " + health2);
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья. Оба гладиатора умерли");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Победа гладиатора 2, Гладиатор 1 погиб");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Победа гладиатора 1, Гладиатор 2 погиб");
            }
        }
    }
}
