using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Nr._3
{
    public class Statusis_trikampis : Figura, IGeometrija
    {
        public readonly double Skaicius;

        public Statusis_trikampis(double skaicius, string figurospavadinimas) : base(figurospavadinimas)
        {
            Skaicius = skaicius;
        }

        public double Perimetras()
        {
            double statusis_perimetras = Skaicius + Skaicius + Skaicius;
            return statusis_perimetras;
        }

        public double Plotas()
        {
            double statusis_plotas = (Skaicius * Skaicius) / 2;
            return statusis_plotas;
        }
    }
}
