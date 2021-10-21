using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pamoka_task_6_my_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Program informacijos_pateikimas = new Program();

            informacijos_pateikimas.Metodas1();
            informacijos_pateikimas.Metodas2();

            Console.ReadKey();
        }
        public void Metodas1 ()
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6\mytest.txt";

            
            if (File.Exists(filePath))
            {
                Console.WriteLine("Taip, failas yra sukurtas");
            }
            else
            {
                Console.WriteLine("Ne, failas nera sukurtas");
            }

            using (FileStream fileStream = File.Create(filePath))
            {
                Console.WriteLine("failas yra sukuriamas su pavadinimu mytest.txt");
            }
        }

        public void Metodas2()
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6\mytest.txt";
            string filePath0 = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6\mytest1.txt";

            try
            {
                List<string> pridetiIrasa = new List<string>();
                pridetiIrasa.Add("Pridedu");
                pridetiIrasa.Add("Irasa");
                pridetiIrasa.Add("I");
                pridetiIrasa.Add("savo");
                pridetiIrasa.Add("Sarasa");

                File.WriteAllLines(filePath, pridetiIrasa);

                File.ReadAllLines(filePath).ToList();

                Console.WriteLine("I faila yra prideti irasai");
                for (int i = 0; i < pridetiIrasa.Count(); i++)
                {
                    Console.WriteLine(pridetiIrasa.ElementAt(i));
                }
            }
            catch (Exception Klaidos_atveju)
            {
                Console.WriteLine(Klaidos_atveju);
                File.Copy(filePath, filePath0);
            }
        }
    }
}
