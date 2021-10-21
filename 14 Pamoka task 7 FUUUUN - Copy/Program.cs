using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pamoka_task_7_FUUUUN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite vartotojo varda");
            string vartotojoVardas = Console.ReadLine();

            Console.WriteLine("Irasykite vartotojo slaptazodi");
            string vartotojoSlaptazodis = Console.ReadLine();

            Program metaDuomenys = new Program();

            metaDuomenys.Prisijungti(vartotojoVardas, vartotojoSlaptazodis);

            bool ar_nori_kartoti = true;

            while (ar_nori_kartoti)

            Console.ReadKey();
        }

        public void Registruotis(string registracijosVardas, string registracijosSlaptazodis)
        {
            string filePatch = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6 Nr 2\mytest.txt";

            //if (registracijosVardas) ???

            Console.WriteLine("Sveikinu Jus sukurete nauja paskytra");
            Console.WriteLine($"Vartojo vardas: {registracijosVardas}");
            Console.WriteLine($"Vartojo slaptazodis: {registracijosSlaptazodis}");

        }

        public void Prisijungti (string prisijungimoVardas, string prisijungimoSlaptazodis)
        {
           if (prisijungimoVardas == "Zygimantas" && prisijungimoSlaptazodis == "123456")
           {
              Console.WriteLine("Jus sekmingai prisijungete");
           }
           else
           {
              Console.WriteLine("Jusu prisijungimas nesekmingas");
           }
        }
    }
}
