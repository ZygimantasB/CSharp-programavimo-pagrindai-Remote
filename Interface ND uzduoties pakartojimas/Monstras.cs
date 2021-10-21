using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ND_uzduoties_pakartojimas
{
    class Monstras : Zaidejas, IPuolimas
    {
        public int Monstro_gyvybes_taskai;
        public string Monstras_puola; // Kanda
        public int MonstroPuolimas;

        public Monstras () : base()
        {
            Monstro_gyvybes_taskai = 10;
            Monstras_puola = "Kandu";
            MonstroPuolimas = -1;
        }

        public void IPuolimas()
        {
            Console.WriteLine($"Monstras puola: {MonstroPuolimas}");
            Console.WriteLine($"Zaidejo gyvybes taskai: {MonstroPuolimas - Zaidejo_gyvybes_taskai}");
            Console.WriteLine($"Zaidejui like gyvybes taskai: {MonstroPuolimas - Zaidejo_gyvybes_taskai}");

            if (Monstro_gyvybes_taskai < 0)
            {
                Console.WriteLine("Monstras mire");
            }
        }
    }
}
