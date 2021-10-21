using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            /// WeekDay uzduotys
            Console.WriteLine("------------Savaites dienos-----------");

            WeekDay metodas = WeekDay.Sekmadienis;
            Console.WriteLine("Jei norime grazinti skaiciu: " + (int)metodas); // parasius int man grazins skaiciu

            Console.WriteLine("Jei norime zinoti kam priklauso: " + metodas); // parasius be skaiciaus t.y. int man parasys diena

            int metodas1 = 4;
            Console.WriteLine("Jei norime zinoti kam priskirtas skaicius: " + (WeekDay)metodas1); // siame pvz mes randame kam yra
                                                                                                  // priskirtas skaicius 4 t.y. kevirtadienis

            Console.WriteLine("Jei norime paversti i string " + metodas.ToString());

            // jei norime patikrinti ar toks zodis yra

            string metodas2 = "Penktadienis";
            string metodas3 = "Penkiolika";
            WeekDay getParse;
            bool checkParse = Enum.TryParse(metodas2, out getParse);
            Console.WriteLine(getParse);
            Console.WriteLine(checkParse); // isreiskia bool versija
            bool checkParse1 = Enum.TryParse(metodas3, out getParse);
            Console.WriteLine(getParse);
            Console.WriteLine(checkParse1);

            Console.WriteLine("-------------Uzduotis menesiai ----------------------");

            Menesiai bandymas = Menesiai.Sausis;

            Console.WriteLine(bandymas);

            Console.WriteLine((int)bandymas);

            int bandymas1 = 31;
            var bandymas4 = (Menesiai)bandymas1;
            Console.WriteLine(bandymas4);

            int bandymas2 = 30;
            Console.WriteLine((Menesiai)bandymas2);

            string bandymas3 = "Sausis";
            Menesiai getParse1;
            bool checkParse12 = Enum.TryParse(bandymas3, out getParse1);
            Console.WriteLine(getParse1);
            Console.WriteLine(checkParse12);

            Console.WriteLine("------------- Maragie Status ----------------------");

            Vedybos bandymas5 = Vedybos.Vedusi;

            Console.WriteLine(bandymas5);

            Console.WriteLine((int)bandymas5);

            int bandymas6 = 2;
            Console.WriteLine((Vedybos)bandymas6);

            string bandymas7 = "Gerule";
            Vedybos getParse2;
            bool checkParse2 = Enum.TryParse(bandymas7, out getParse2);
            Console.WriteLine(getParse2);
            Console.WriteLine(checkParse2);

            Console.WriteLine("Pasirinkite ar mergina yra vedusi ar ne 1 TAIP 2 NE");
            int pasirinkimas = int.Parse(Console.ReadLine());

            Console.WriteLine(pasirinkimas);
           



            Console.ReadKey();
        }
    }
}
