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
            Console.WriteLine("Sveiki pasirinkite prisijungti jei jau esate uzregistraves vartotoje, jei ne registruokite nauja vartotoja");
            string vartotojoPasirinkimas = Console.ReadLine().ToLower();

            Console.WriteLine("Irasykite vartotojo varda");
            string vartotojoVardas = Console.ReadLine();

            Console.WriteLine("Irasykite vartotojo slaptazodi");
            string vartotojoSlaptazodis = Console.ReadLine();

            Program metaDuomenys = new Program();

            bool pakartojimas = true;

            while (pakartojimas)
            {
                switch (vartotojoPasirinkimas)
                {
                    case "prisijungti":
                        metaDuomenys.Prisijungti(vartotojoVardas, vartotojoSlaptazodis);
                        pakartojimas = false;
                        break;
                    case "registracija":
                        metaDuomenys.Registruotis(vartotojoVardas, vartotojoSlaptazodis);
                        pakartojimas = false;
                        break;
                }
            }

            Console.ReadKey();
        }

        public void Registruotis(string registracijosVardas, string registracijosSlaptazodis)
        {

            string filePatch = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6 Nr 2\mytest.txt";

            List<string> isaugotiDuomenys = new List<string>();
            isaugotiDuomenys.Add(registracijosVardas);
            isaugotiDuomenys.Add(registracijosSlaptazodis);

            string perskaitomasFailas = File.ReadAllLines(filePatch).ToString();

            foreach(var skaitomiDuomenys in isaugotiDuomenys)
            {
                if(skaitomiDuomenys == perskaitomasFailas)
                {
                    Console.WriteLine("Vartotojas tokiu vardu egzistuoja");
                }
                else if (registracijosSlaptazodis.Length > 6)
                {
                    Console.WriteLine("Slaptazodis turi buti ilgesnis nei 6 simboliai");
                }
            }

            if (isaugotiDuomenys == "Zygimantas")
            {
                Console.WriteLine("Vartotojas tokiu vardu yra registruotas");
            }
            else if (perskaitomasFailas.Length > 6)
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

            string eilute = "";

            File.WriteAllText(filePath, prisijungimoVardas + " " + prisijungimoSlaptazodis);

            //string perskaitomasTekstas = File.ReadLines(filePath).ToString(); Bereikalignas kodas

            using (StreamReader sr = File.OpenText(filePath))

                eilute = sr.ReadLine();
                if (eilute != null)
                {
                    Console.WriteLine("Jus sekmingai prisijungete");
                }
                else
                {
                    Console.WriteLine("Jusu prisijungimas nesekmingas, neteisingai suvestas vartotojo vardas arba slaptažodis");
                }
        }
        //private readonly string _path = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6 Nr 2\mytest.txt";
        //public bool UserNamePatirkinimas (string name)
        //{
        //    string eilute = "";
        //    try
        //    {
        //        using (StreamReader sr = File.OpenText(_path))
        //        {
        //            eilute = sr.ReadLine();
        //            string[] duomenys = eilute.Split(' ');
        //            if (duomenys [0] == name)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        
    }
}

