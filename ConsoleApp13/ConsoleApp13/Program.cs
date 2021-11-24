using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            while (true)
            {

                try
                {
                    Console.WriteLine("Hur många heltal");
                    antal = int.Parse(Console.ReadLine());
                    if (antal > 0) { break; }
                    else { Console.WriteLine("inga negativa tal"); }

                }
                catch
                {
                    Console.WriteLine("fel ange heltal");
                }

            }
            int[] tal = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                while (true)
                    try
                    {
                        Console.WriteLine("ange heltal");
                        tal[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("fel");
                    }
                for (int x = antal; antal < 0; antal--)
                {
                    Console.WriteLine(tal);
                }
            }

            
            Console.ReadLine();
        }
    }
}
