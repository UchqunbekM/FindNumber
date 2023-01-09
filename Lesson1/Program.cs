using System;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Random rand= new Random();
            float health1= rand.Next(90, 150);
            float health2= rand.Next(80, 130);
            int damage1= rand.Next(10, 30);
            int damage2= rand.Next(20, 40);
            int armor1= rand.Next(30, 50);
            int armor2=rand.Next(25, 55);

            Console.WriteLine($"Gladiator 1: health={health1}, damage={damage1}, armor={armor1},");
            Console.WriteLine($"Gladiator 2: health={health2}, damage={damage2}, armor={armor2},");

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle( rand.Next(0, damage2+1))/100 * armor1;
                health2 -= Convert.ToSingle( rand.Next(0, damage1+1))/100 * armor2;

                Console.WriteLine($"Gladiator 1: {health1} health.");
                Console.WriteLine($"Gladiator 2: {health2} health.");
            }
            if (health1 <=0 && health2 <=0)
            {
                Console.WriteLine("Draw !");
            } else if (health1 < health2) {
                Console.WriteLine("Gladiator 2 win!");
            } else if (health1 > health2) {
                Console.WriteLine("Gladiator 1 win!");

            }
        }
    }
}
