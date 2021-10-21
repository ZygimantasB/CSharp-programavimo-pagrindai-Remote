using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<int> skaicius = new List<int>();

            Console.WriteLine("Irasykite skaiciu1");
            int skaicius_list = int.Parse(Console.ReadLine());

            bool ar_nori_pakartojimas = true;

            while (skaicius_list != 0)
            {
                Console.WriteLine("Irasykite skaiciu");
                skaicius_list = int.Parse(Console.ReadLine());

                skaicius.Add(skaicius_list);

                ar_nori_pakartojimas = skaicius_list == 0;

                if (ar_nori_pakartojimas)
                {
                    for (int i = 0; i < skaicius.Count; i++)
                    {
                        Console.Write(skaicius.ElementAt(i) + " ");
                    }

                    //foreach (var sarasiukas in skaicius)
                    //{
                    //    Console.Write(sarasiukas + " ");
                    //}
                }

            }
            

            Console.ReadLine();
        }
    }
}
