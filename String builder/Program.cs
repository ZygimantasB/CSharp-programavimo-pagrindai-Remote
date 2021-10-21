using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-------------S T R I N G ------------------");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string s = string.Empty;

            for (int i = 0; i < 10000; i++)
            {
                s += i;
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("-------------S T R I N G    B U I L D E R ------------------");

            Stopwatch swBuilder = new Stopwatch();
            swBuilder.Start();
            StringBuilder sBuilder = new StringBuilder();

            for (int j = 0; j <10000; j++)
            {
                sBuilder.Append(j);
            }
            swBuilder.Stop();
            Console.WriteLine(swBuilder.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
