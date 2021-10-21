using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random bet_koksSkaicius = new Random();

            int skaicius1 = bet_koksSkaicius.Next(1, 1000);

            int skaicius2 = bet_koksSkaicius.Next(1, 1000);

            Console.WriteLine($"{skaicius1} {skaicius2}");

            for (int i = 0; i < 1000; i++ )
            {
                while (skaicius1 != skaicius2)
                {
                    Console.WriteLine($"{skaicius1} {skaicius2}");
                }
            }

            Console.ReadKey();
        }
    }
}
