using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Pamoka_Extension_method.Extensions
{
    static class IntExtensions
    {
        public static int PowerTwo (this int number1, int a)
        {
            number1 = (int)Math.Pow(number1, a);
            return number1;
        }
    }
}
