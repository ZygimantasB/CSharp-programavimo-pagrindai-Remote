using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduoties_pakartojimas
{
    class Naminis_gyvunelis
    {
        public int Naminio_gyvunelio_gyvybesTaskai;

        public Naminis_gyvunelis ()
        {
            Naminio_gyvunelio_gyvybesTaskai = 10;
        }

        public void NaminisGyvunelis_mirsta ()
        {
            if (Naminio_gyvunelio_gyvybesTaskai < 0)
            {
                Console.WriteLine("Naminis gyvunelis mire");
            }
        }
    }
}
