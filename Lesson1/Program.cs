using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, high, low, health, userinput;
            health=5;
          Random rand=new Random();
            number=rand.Next(0, 101);
            low=rand.Next(number-10, number);
            high=rand.Next(number+1, number+10);
            Console.WriteLine($"I Think number! Find it. the number higher than {low} and lower than {high}");
            Console.WriteLine($"You have {health} chance");
            while (health-->0)
            {
                Console.WriteLine("Your number : ");
                userinput=Convert.ToInt32(Console.ReadLine());
                if (userinput==number)
                {
                    Console.WriteLine("Correct !!!");
                    break;
                } else
                {
                    Console.WriteLine("Wrong! try again");
                     
                }
                if (health==0)
                {
                    Console.WriteLine($"The correct number is {number}");

                }

            }

     
        }
    }
}
