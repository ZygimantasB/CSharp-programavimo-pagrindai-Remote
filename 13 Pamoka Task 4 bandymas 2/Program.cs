using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_4_bandymas_2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ar_nori_kartoti = true;

            while (ar_nori_kartoti)
            {
                List<string> sarasas_zodis = new List<string>();

                Console.WriteLine("Irasyktie zodi 1");
                string zodis1 = Console.ReadLine();

                Console.WriteLine("Irasyktie zodi 2");
                string zodis2 = Console.ReadLine();

                Skaiciavimai mano_sarasiukas = new Skaiciavimai(zodis1, zodis2, sarasas_zodis);

                mano_sarasiukas.Metodas_sarasas();

                //if (zodis1 == zodis2)
                //{
                //    Console.WriteLine($"Zodis - {zodis1} - kartojasi (dublicate)");
                //}
                //else if (zodis1 != zodis2)
                //{
                //    Console.WriteLine($"Zodis - {zodis1} - yra isaugotas");
                //    sarasas_zodis.Add(zodis);
                //    sarasas_zodis.Add(zodis1);
                //}
            }

            Console.ReadLine();

        }
    }
}
