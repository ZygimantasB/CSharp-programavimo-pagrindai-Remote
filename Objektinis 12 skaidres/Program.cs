using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_12_skaidres
{
    class Program
    {
        static void Main(string[] args)
        {
            Skaicius aritmetinis_veiksmas = new Skaicius();

            Console.WriteLine("Irasyktie skaiciu: ");
            int veiksmas = Convert.ToInt32(Console.ReadLine());

            int sudetis = aritmetinis_veiksmas.Prideti(veiksmas);
            int atimtis = aritmetinis_veiksmas.Atimti(veiksmas);
            int padauginti = aritmetinis_veiksmas.Pdauginti(veiksmas);
            double padalinti = aritmetinis_veiksmas.Padalinti(veiksmas);
            int pakelimas_kvadratu = aritmetinis_veiksmas;

            Console.ReadKey();

        }
    }
}
