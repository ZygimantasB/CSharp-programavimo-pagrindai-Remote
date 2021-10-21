using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pamoka_Event
{
    class Program
    {
        //public delegate void EventHandler(string message);
        public static event EventHandler<string[]> MyEvent;
        static void Main(string[] args)
        {
        }
        public static void BankZinute(string zinute)
        {
            MyEvent.Invoke("Bankas", zinute);
        }
    }
}
