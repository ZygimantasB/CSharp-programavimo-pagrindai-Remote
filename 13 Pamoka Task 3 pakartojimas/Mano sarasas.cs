using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_3_pakartojimas
{
    class Mano_sarasas
    {
        public List<int> Mano_skaiciai;
        private int Skaicius;

        public Mano_sarasas(int skaicius)
        {
            Skaicius = skaicius;
        }

        public Mano_sarasas(List<int> mano_skaiciai, int skaicius)
        {
            Mano_skaiciai = mano_skaiciai;
            Skaicius = skaicius;
        }

        public void Begalinis_sarasiukas (int skaicius)
        {
            Console.WriteLine("Irasyktie skaiciu");
            skaicius = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Mano_skaiciai.Count; i++)
            {
                Mano_skaiciai = new List<int>();
                Mano_skaiciai.Add(skaicius);
            }


        }
    }
}
