using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pamoka_Eventai_Uzduotis
{
    class Program
    {
        public static event EventHandler MyEvent;
        static void Main(string[] args)
        {
            MyEvent += (s,e) => Console.WriteLine("hi"); 
            MyEvent += (s,e) => Console.WriteLine("hi"); 
            MyEvent += (s,e) => Console.WriteLine("hi"); 
            MyEvent += (s,e) => Console.WriteLine("hi");

            SavotiskaiPasveiktinit("Hello");
            Console.ReadLine();
        }
        public static void SavotiskaiPasveiktinit(string fraze)
        {
            MyEvent.Invoke(null, EventArgs.Empty);
        }
        
    }
}
