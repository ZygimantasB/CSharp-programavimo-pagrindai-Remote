using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pamoka_delegatai_Uzduotis
{
    public delegate void DoOperation(int m1, int m2);
    class Program
    {
        public static DoOperation aritmetiniaiVeiksmai;

        static void Main(string[] args)
        {
            aritmetiniaiVeiksmai = MyMultiplay;
            aritmetiniaiVeiksmai(9, 3);
            aritmetiniaiVeiksmai = MySum;
            aritmetiniaiVeiksmai(7, 8);
            aritmetiniaiVeiksmai += MySum;
            aritmetiniaiVeiksmai(4, 6);

            Console.ReadLine(); 
        }

        static void MyMultiplay(int m1, int m2)
        {
            Console.WriteLine($"{m1} * {m2} = {m1*m2}");
        }
        static void MySum (int m1, int m2)
        {
            Console.WriteLine($"{m1} + {m2} = {m1 + m2}");
        }
    }
}
