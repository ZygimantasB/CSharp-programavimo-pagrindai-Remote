using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Pamoka_Extension_methods
{
    public class UnitController<T> where T : IPrintable, new ()
    {
        T Reiksme;
       public UnitController ()
        {
            Reiksme = new T();
        }
    }
}
