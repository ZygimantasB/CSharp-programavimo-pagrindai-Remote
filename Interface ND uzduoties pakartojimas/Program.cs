using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduoties_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaidejas objektas_zaidejas = new Zaidejas();

            Monstras objektas_monstras = new Monstras();

            objektas_zaidejas.Puolimas();

            Console.ReadLine();
        }
    }
}
