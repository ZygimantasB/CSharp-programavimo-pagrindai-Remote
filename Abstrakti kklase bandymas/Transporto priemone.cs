using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti_kklase_bandymas
{
    abstract class Transporto_priemone
    {
        string Pavadinimas;
        int Vidutinis_greitis;

        public Transporto_priemone (string pavadinimas, int vidutinis_greitis)
        {
            Pavadinimas = pavadinimas;
            Vidutinis_greitis = vidutinis_greitis;

           abstract public void Vaziuoti()
        {
            Console.WriteLine($" Transporto priemone {Pavadinimas}, kurios vidutinis greitis {Vidutinis_greitis}");
        }

    }
}
