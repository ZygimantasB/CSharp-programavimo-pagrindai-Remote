using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_2
{
    class Skaiciavimai
    {
        public int Skaicius1;
        public int Skaicius2;
        public int Skaicius3;
        public int Skaicius4;
        
        public Skaiciavimai (int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            Skaicius1 = skaicius1;
            Skaicius2 = skaicius2;
            Skaicius3 = skaicius3;
            Skaicius4 = skaicius4;
        }
        public void Patikrinimas_uzduoties (int skaicius1, int skaicius2, int skaicius3, int skaicius4)
        {
            if (skaicius1 < 0 || skaicius2 < 0 || skaicius3 < 0 || skaicius4 < 0)
            {
                Console.WriteLine("Vienas is skaiciu yra neigiamas, klaida, neglalima atlikti veiksmo");
            }
            else
            {
                Console.WriteLine($"{skaicius1} + {skaicius2} + {skaicius3} + {skaicius4} = {skaicius1+ skaicius2+ skaicius3+ skaicius4}");
                Console.WriteLine($"{skaicius1} - {skaicius2} - {skaicius3} - {skaicius4} = {skaicius1- skaicius2- skaicius3- skaicius4}");
                Console.WriteLine($"{skaicius1} * {skaicius2} * {skaicius3} * {skaicius4} = {skaicius1* skaicius2* skaicius3* skaicius4}");
                Console.WriteLine($"{skaicius1} / {skaicius2} / {skaicius3} / {skaicius4} = {(double)skaicius1 / (double)skaicius2 / (double)skaicius3 / (double)skaicius4}");
            }
        }
    }
}
