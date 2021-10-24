using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pamoka_Event1
{
    class Bankas
    {
        public string BankoPavadinimas;
        public double DisponiojamosLeses;

        //public int PerverdamiPinigai;
        //public int  IdedamiPinigai;
        //public int KeiciamiPinigia;

        public Bankas (string bankoPavadinimas, double disponuojamosLeses)
        {
            BankoPavadinimas = bankoPavadinimas;
            DisponiojamosLeses = disponuojamosLeses;
        }

        public double Deposite (double suma)
        {
            DisponiojamosLeses = DisponiojamosLeses + suma;
            BankoOperacija?.Invoke(this, $"Jus gavote is banko dovanu"); //this rodo, kad bus naujas objektas surkurtas 6ioje klas4je
            IdetiPinigai?.Invoke(this, $"Jus i banko sasakita idejote pinigu {DisponiojamosLeses}");
            return DisponiojamosLeses;
        }
        public double IsiimamiPingai (double suma)
        {
            DisponiojamosLeses = DisponiojamosLeses - suma;
            IsimtiPinigai?.Invoke(this, "Jus nuo ssakaitops nuemete pinigu");
            PakeistaVAliuta?.Invoke(this, "Jus pakeitete turimas lesas i ktia valiuta");
            return DisponiojamosLeses;
        }

        public double KeiciamiPinigai (double suma, string valiuta, double valiutosKursas)
        {
            DisponiojamosLeses = DisponiojamosLeses * valiutosKursas;
            Console.WriteLine($"{suma} {DisponiojamosLeses}");
            return DisponiojamosLeses;
        }
        public event EventHandler<string> BankoOperacija;
        public event EventHandler<string> IdetiPinigai;
        public event EventHandler<string> IsimtiPinigai;
        public event EventHandler<string> PakeistaVAliuta;
    }
}
