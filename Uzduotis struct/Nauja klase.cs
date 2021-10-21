using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_struct
{
    public struct Nauja_klase : IPrint_data
    {
        public string Pasisveikinti { get; set; }
        public int IsgalvotasSkaicius { get; set; }
        public List<string> Vardai;

        public Nauja_klase (string pasisveikinti, int isgalvotasskaicius, List<string> vardai)
        {
            Pasisveikinti = pasisveikinti;
            IsgalvotasSkaicius = isgalvotasskaicius;
            Vardai = vardai;

            //List<string> Vardai = new List<string> { "Gerda", "Tomas", "Gediminas" };

        }

        public void Pasisveikinimas()
        {
            Console.WriteLine($"Man pavyko parasyti {Pasisveikinti}. " +
                $"As sugalvojau skaiciu {IsgalvotasSkaicius}. Yra tokie vardai {Vardai}");
        }
    }

}
