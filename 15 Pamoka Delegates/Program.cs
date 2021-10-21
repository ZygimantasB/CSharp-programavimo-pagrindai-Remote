using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pamoka_Delegates
{
    public delegate int DoOperation(int m1, int m2);

    class Program
    {
        private static DoOperation ManoDelegatas;

        static void Main(string[] args)
        {
            Console.WriteLine($"Irasyktie pirma skaiciu");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Irasyktie pirma skaiciu");
            int number2 = int.Parse(Console.ReadLine());

            ManoDelegatas = MySum;
            ManoDelegatas = MyMultiplay;
        }

        public void DoOperation (int m1, int m2)
        {
            
        }
        static void MyMultiplay(int m1, int m2)
        {
            Console.WriteLine($"{m1} * {m2} = {m1 * m2}");
            return m1 + m2;
        }
        static void MySum (int m1, int m2)
        {
            Console.WriteLine($"{m1} + {m2} = {m1 + m2}");
            return m1 + m2;
        }
    }
}
