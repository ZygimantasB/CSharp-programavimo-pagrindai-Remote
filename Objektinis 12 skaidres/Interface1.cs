using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_12_skaidres
{
    interface IMatematika // interface pagal pagal nutytlėjimą yra public
    {
        int Prideti(int skaicius);
        int Atimti(int skaicius);
        int Pdauginti(int skaicius);
        double Padalinti(int skaicius); // kokia reikšmę pasiims, todėl prie skaicius int, nėra būtina double.
        int Pakelti_kvadratu(int skaicius);
        int Pakelti_kubu(int skaicius);
    }
}
