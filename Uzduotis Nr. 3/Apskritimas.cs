using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Nr._3
{
    public class Apskritimas : Figura, IGeometrija
    {
        public readonly double Skaicius;

        public Apskritimas(double skaicius, string figurospavadinimas) : base(figurospavadinimas)
        {
            Skaicius = skaicius;
        }
        public double Perimetras()
        {
            double statusis_perimetras = 2 * Math.PI * Skaicius;
            return statusis_perimetras;
        }

        public double Plotas()
        {
            double apskritimo_plotas = Math.PI * Math.Pow(Skaicius, 2);
            return apskritimo_plotas;
        }
    }
}
