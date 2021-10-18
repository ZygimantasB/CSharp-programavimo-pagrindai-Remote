using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_1_pakartojimas_nr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void IsvestiRezultata(Galimybes galimybe)
        {
            switch (galimybe)
            {
                case Galimybes.nieko:
                    Console.WriteLine("Asmuo negali vairuoti ir gerti");
                    break;

                case Galimybes.vairuoti:
                    Console.WriteLine("Asmuo gali vairuoti, taciau gerti negali");
                    break;

                case Galimybes.vairuotiirgerti:
                    Console.WriteLine("Asmuo gali vairutoi ir gerti");
                    break;
            }
        }
    }
}
