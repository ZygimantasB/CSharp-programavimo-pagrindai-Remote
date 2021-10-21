using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pamoka_5_task_bandymas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ivestiduomenys = IvestiDuomenys();
            Manoduomenys(ivestiduomenys);

            Console.ReadLine();
        }
        public static string IvestiDuomenys()
        {
            Console.WriteLine("iraasykite savo duomenis");
            string data = Console.ReadLine();
            return data;
        }

        public static void Manoduomenys (string duomenys)
        {
            string vieta = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Failu sukurimas1";
            //File.WriteAllText(vieta, duomenys);
            DirectoryInfo direktorija = Directory.GetParent(vieta);

            if (direktorija.Exists == true)
            {
                File.WriteAllText(vieta, duomenys);
            }
            else
            {
                Console.WriteLine("Ivyko klaida, vieta neegzistuoja");
            }


            //try
            //{
            //    string vieta = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Failu sukurimas1";
            //    File.WriteAllText(vieta, duomenys);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Tokios direktorijos nera");
            //}
        }
    }
}
