using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_4_bandymas_2
{
    public class Skaiciavimai
    {
        public string Zodis1;
        public string Zodis2;

        public List<string> Sarasiukas { get; private set; }

        public Skaiciavimai(string zodis1, string zodis2, List<string> saraiuskas)
        {
            Zodis1 = zodis1;
            Zodis2 = zodis2;
            Sarasiukas = saraiuskas;
        }

        public void Metodas_sarasas()
        {
            if (Zodis1 == Zodis2)
            {
                Console.WriteLine($"Zodis -- {Zodis1} -- kartojasi");
            }
            else if (Zodis1 != Zodis2)
            {
                Console.WriteLine($"Zodis -- {Zodis1} ir {Zodis2} -- yra isaugotas");
                Sarasiukas.Add(Zodis1);
                Sarasiukas.Add(Zodis2);
            }
        }
    }
}
