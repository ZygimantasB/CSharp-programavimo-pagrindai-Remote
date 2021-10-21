using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pamoka_Event1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankas manoBankas = new Bankas("SwedBank", 99999.99);
            manoBankas.IdetiPinigai += Manobankas_IdetiPinigai;
            manoBankas.Deposite(1000);

            //EventHandler rei6kia, akd bus tusti evento parametrai. 

            Console.ReadKey();
        }
        private static void Manobankas_IdetiPinigai (object sender, string e)
        {
            //Console.WriteLine(e);
        }
    }
}
