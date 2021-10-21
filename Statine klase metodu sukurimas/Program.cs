using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statine_klase_metodu_sukurimas
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius = General.NuskaitytiDoubleSkaiciu();

            Console.WriteLine(skaicius);

            int skaicius1 = General.Nuskaityti_sveikaji_skaiciu();

            Console.WriteLine(skaicius1);

            Console.ReadKey();
        }
    }
}
