using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Nr._3
{
    public class Staciakampis : Figura, IGeometrija
    {
        public readonly double Skaicius;

        public Staciakampis (double skaicius, string figurospavadinimas) : base(figurospavadinimas)
        {
            Skaicius = skaicius;
        }
        public double Perimetras()
        {
            double staciakampio_perimetras = 2 * (Skaicius + Skaicius);
            return staciakampio_perimetras;
        }

        public double Plotas()
        {
            double staciakampio_plotas = Skaicius * Skaicius;
            return staciakampio_plotas;
        }
    }
}
