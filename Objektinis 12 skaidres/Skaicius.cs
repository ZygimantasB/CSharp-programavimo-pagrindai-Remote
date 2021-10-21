using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_12_skaidres
{
    class Skaicius // paspausti dešinį klavišą ir paspausti implament iterface viską man aprašys
    {
        private readonly int skaicius;

        public int Atimti(int skaicius)
        {
            int atimtis = skaicius - skaicius;
            return atimtis;

            //throw new NotImplementedException(); Jis ismetą kalidą, kad metodas yra neimplementuotas
        }

        public double Padalinti(int skaicius)
        {
            double dalyba = skaicius / skaicius;
            return dalyba;
        }

        public int Pdauginti(int skaicius)
        {
            int daugyba = skaicius * skaicius;
            return daugyba;
        }

        public int Prideti(int skaicius)
        {
            int sudetis = skaicius + skaicius;
            return sudetis;
        }

        int Pakelti_kubu(int skaicius)
        {
            int pakelti_kvadratu = skaicius * skaicius;
            return pakelti_kvadratu;
        }

        int Pakelti_kvadratu(int skaicius)
        {
            int pakelti_kubu = skaicius * skaicius * skaicius;
            return pakelti_kubu;
        }
    }
}
