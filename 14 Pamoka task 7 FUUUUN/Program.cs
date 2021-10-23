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
            Console.WriteLine("Sveikti jei turite vartotoja prasome prisijungti, jei ne registruokite nauja vartotoja");
            string registracija_ar_prisijungimas = Console.ReadLine();

            Console.WriteLine("Irasykite vartotojo varda");
            string vartotojoVardas = Console.ReadLine();

            Console.WriteLine("Irasykite vartotojo slaptazodi");
            string vartotojoSlaptazodis = Console.ReadLine();

            Program metaDuomenys = new Program();

            switch (registracija_ar_prisijungimas)
            {
                case "Prisijungti":
                    metaDuomenys.Prisijungti(vartotojoVardas, vartotojoSlaptazodis);
                    break;
                case "Registracija":
                    metaDuomenys.Registruotis(vartotojoVardas, vartotojoSlaptazodis);
                    break;
            }

            Console.ReadKey();
        }

        public void Registruotis(string registracijosVardas, string registracijosSlaptazodis)
        {
            string filePatch = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6 Nr 2\mytest.txt";

            string perskaitomasFailas = File.ReadAllLines(filePatch).ToString();

            if (perskaitomasFailas == "Zygimantas")
            {
                Console.WriteLine("Vartotojas tokiu vardu yra registruotas");
            }
            else if (perskaitomasFailas.Length < 7)
            {
                Console.WriteLine("Slaptazodis negali buti ilgesnis nei 6 skaitmenys");
            }
            else
            {
                Console.WriteLine($"Vartojo vardas: {registracijosVardas}");
                Console.WriteLine($"Vartojo slaptazodis: {registracijosSlaptazodis}");
                Console.WriteLine("Sveikinu Jus sukurete nauja paskytra");

                List<string> registruotoVartotojoInfo = new List<string>();
                registruotoVartotojoInfo.Add(registracijosVardas + "\n");
                registruotoVartotojoInfo.Add(registracijosSlaptazodis);

                foreach (var irasaiFaile in registruotoVartotojoInfo)
                {
                    Console.WriteLine(irasaiFaile);
                    File.AppendAllText(filePatch, irasaiFaile);
                }
            }
        }

        public void Prisijungti (string prisijungimoVardas, string prisijungimoSlaptazodis)
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6 Nr 2\mytest.txt";

            string perskaitomasTekstas = File.ReadLines(filePath,);

            if (perskaitomasTekstas == "Zygimantas" && perskaitomasTekstas == "123456")
                {
                    Console.WriteLine("Jus sekmingai prisijungete");
                }
                else
                {
                    Console.WriteLine("Jusu prisijungimas nesekmingas, neteisingai suvestas vartotojo vardas arba slaptažodis");
                }
        }
    }
}
