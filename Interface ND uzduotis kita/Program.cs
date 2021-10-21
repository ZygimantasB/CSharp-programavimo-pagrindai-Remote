using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduotis_kita
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Kate objektas_kate = new Kate();

            Bezdzione objektas_monkey = new Bezdzione();

            List<Gyvunas> manoSarasas = new List<Gyvunas>();
            manoSarasas.Add(new Kate());
            manoSarasas.Add(new Gyvunas());
            //manoSarasas.Add(objektas_monkey);
        }
    }
}
