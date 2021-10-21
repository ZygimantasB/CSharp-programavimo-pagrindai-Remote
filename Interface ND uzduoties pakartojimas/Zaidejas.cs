using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduoties_pakartojimas
{
    class Zaidejas : Naminis_gyvunelis, IPuolimas
    {
        public int Zaidejo_gyvybes_taskai;
        public string Zaidejas_puola; // kerta is kalavijo
        public int Zaidejo_kirtis;

        public Zaidejas () : base()
        {
            Zaidejo_gyvybes_taskai = 10;
            Zaidejas_puola = "Kertu is kalavijo";
            Zaidejo_kirtis = -1;
        }

        public void Puolimas()
        {
            Monstras objektas_monstras = new Monstras();
            
            Console.WriteLine($"{Zaidejas_puola}. Monstrui {objektas_monstras.Monstro_gyvybes_taskai - Zaidejo_kirtis}");
            Console.WriteLine($"Monstrui like gyvybes taskai {objektas_monstras.Monstro_gyvybes_taskai - Zaidejo_kirtis}");

            if (Zaidejo_gyvybes_taskai < 0)
            {
                Console.WriteLine("Zaidejas mire");
            }
        }
    }
}
