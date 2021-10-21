using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_2_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius4 = int.Parse(Console.ReadLine());

            Teigiami_skaiciai objekto_sukurimas = new Teigiami_skaiciai(skaicius1, skaicius2, skaicius3, skaicius4);

            objekto_sukurimas.Sudetis(skaicius1, skaicius2, skaicius3, skaicius4);

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius8 = int.Parse(Console.ReadLine());

            objekto_sukurimas.Atimtis(skaicius5, skaicius6, skaicius7, skaicius8);

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius10 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius11 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius12 = int.Parse(Console.ReadLine());

            objekto_sukurimas.Daugyba(skaicius9, skaicius10, skaicius11, skaicius12);

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius13 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius14 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius15 = int.Parse(Console.ReadLine());

            Console.WriteLine("Irasykite pirma skaiciu");
            int skaicius16 = int.Parse(Console.ReadLine());

            objekto_sukurimas.Dalyba(skaicius13, skaicius14, skaicius15, skaicius16);

            Console.ReadLine();
        }
    }
}
