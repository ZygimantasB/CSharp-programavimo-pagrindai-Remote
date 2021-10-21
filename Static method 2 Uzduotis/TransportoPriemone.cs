using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method_2_Uzduotis
{
    abstract class TransportoPriemone
    {
        public string Pavadinimas;
        public int VidutiniGreiti;

        public TransportoPriemone(string pavadinimas, int vidutinisgreiti)
        {
            Pavadinimas = pavadinimas;
            VidutiniGreiti = vidutinisgreiti;
        }

        abstract public void Vaziuoti();

        
    }
}
