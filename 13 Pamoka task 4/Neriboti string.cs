using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_task_4
{
    public class Neriboti_string
    {
        public string Skaiciai_zodiziai;

        public Neriboti_string (string skaiciai_zodziai)
        {
            Skaiciai_zodiziai = skaiciai_zodziai;
        }

        public void Patikrinimas ()
        {
            if (Skaiciai_zodiziai == Skaiciai_zodiziai)
            {
                Console.WriteLine($"Sis zodis yra pasikartojantis {Skaiciai_zodiziai}");
            }
            if (Skaiciai_zodiziai != Skaiciai_zodiziai)
            {
                Console.WriteLine("Zodis yra isaugotas");
            }
        }
    }
}
