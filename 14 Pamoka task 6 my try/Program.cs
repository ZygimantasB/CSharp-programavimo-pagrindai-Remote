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
        }

        public void Metodas2()
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6\mytest.txt";
            string filePath0 = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Task 6\mytest1.txt";

            try
            {
                using (StreamWriter strWriter = File.CreateText(filePath))
                {
                    Console.WriteLine("I faila yra pridedami irasai");
                    strWriter.WriteLine("Pridedu");
                    strWriter.WriteLine("Irasa");
                    strWriter.WriteLine("I");
                    strWriter.WriteLine("savo");
                    strWriter.WriteLine("sarassa");
                    
                }
            }
            catch (Exception Klaidos_atveju)
            {
                using (StreamWriter strWriter = File.CreateText(filePath0))
                {
                    strWriter.WriteLine(Klaidos_atveju);
                }
            }
        }
    }
}
