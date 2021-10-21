using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_pasubandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            string bandymas = "   Man patinka programuoti\n\n, dabar bandysu \tatlitki uzduotis\n su string   ";
            Console.WriteLine(bandymas);
            Console.WriteLine("------------------------------------------------------------");

            //Console.WriteLine($"1. Trim rezultatas be \n: {bandymas.Trim('\t')}"); // po default naikina naujas eilutes ir tarpus
            //Console.WriteLine($"2. Trim rezultatas: {bandymas.Trim('\n')}"); 

            //Console.WriteLine($"3. Trim rezultatas be: {bandymas.Trim()}");
            //Console.WriteLine($"4. Split rezultatas be: {bandymas.Split(' ')}");
            //Console.WriteLine($"4. Trim rezultatas be: {bandymas.Split(' ')}");

            string zodis = "Labas Rytas";

            var indeksas = zodis.IndexOf(' ');
            var bandymas1 = zodis.Substring(0, indeksas);
            var bandymas2 = zodis.Substring(indeksas + 1);
            Console.WriteLine($"bandymas1 {bandymas1}");
            Console.WriteLine($"bandymas2 {bandymas2}");
            Console.WriteLine( bandymas1 + " " + bandymas2);

            Console.WriteLine(zodis.Replace("Rytas", "Vakaras"));
            Console.WriteLine("Pakeitimas: " + zodis);
            Console.WriteLine(zodis.Replace("a", "A"));
            Console.WriteLine("Dar vienas pakeitimas: " + zodis);

            if (string.IsNullOrEmpty(" ".Trim()))

                if (string.IsNullOrWhiteSpace(" ".Trim()))


            //var indeksas = bandymas.IndexOf(' ');
            //var bandymas1 = bandymas.Substring(30, indeksas);
            //var bandymas2 = bandymas.Substring(indeksas, 15);
            //Console.WriteLine($"bandymas1 {bandymas1}");
            //Console.WriteLine($"bandymas2 {bandymas2}");






            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
