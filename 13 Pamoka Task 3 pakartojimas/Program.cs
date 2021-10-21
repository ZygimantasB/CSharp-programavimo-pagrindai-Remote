using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_3_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pakartojimas = true;

            Console.WriteLine("Irasyktie mano skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            
            Mano_sarasas objekto_sukurimas = new Mano_sarasas(skaicius);

            while (skaicius != 0)
            {
                pakartojimas = skaicius == 0;

                if(pakartojimas)
                {
                    objekto_sukurimas.Begalinis_sarasiukas(skaicius);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
