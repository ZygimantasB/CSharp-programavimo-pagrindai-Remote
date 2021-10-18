using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_1_pakartojimas
{
    class AmziausNuskaitymas
    {
        public int Nuskaitymas()
        {
            Console.WriteLine("Irasykite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            return amzius;
        }

            public Galimybes AmziausIvertinimas (int amzius)
            {
                if (amzius < 18)
                {
                    return Galimybes.nieko;
                }
                if (amzius >= 18 && amzius <= 20)
                {
                    return Galimybes.vairuoti;
                }
                else 
                {
                    return Galimybes.vairuotiGerti;
                }

            }
        }
    }

