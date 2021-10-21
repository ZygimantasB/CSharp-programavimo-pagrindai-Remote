using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Nr._3
{
    public class Kvadratas : Figura, IGeometrija
    {
        public readonly double Skaicius;
        public Kvadratas(double skaicius, string figurospavadinimas) : base(figurospavadinimas)
        {
            Skaicius = skaicius;
        }
        public double Plotas()
        {
            double kvadrato_plotas = Skaicius * Skaicius;
            return kvadrato_plotas;
        }

        public double Perimetras()
        {
            double kvadrato_perimetras = Skaicius * 4;
            return kvadrato_perimetras;
        }

    }
}
