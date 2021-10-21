using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pamoka_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"G:\My Drive\C Sharp mokymai video\Paskaitos video\14 Pamoka\Failu sukurimas\test.txt";

            //string[] lines = File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Siandien bus 14 paskaita");
            File.WriteAllLines(filePath, lines);

            if (File.Exists(filePath) == false)
            {
                Console.WriteLine("Viskas gerai, faila pavyko irasyti i nurodyta direktorija");
            }
            else
            {
                Console.WriteLine("Tokios direktorijos nera failo irasyti i direktorija nepavyko");
            }

                Console.ReadLine();
        }
    }
}
