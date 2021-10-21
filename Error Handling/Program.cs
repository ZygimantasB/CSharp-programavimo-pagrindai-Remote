using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int[] masyvas = new int[3];
                //int test = Convert.ToInt32(Console.ReadLine());
                //masyvas[5] = test;

                int i = 1500;
                byte j = byte.Parse(i.ToString());

                Console.WriteLine(j);

                var number = "123456789";
                byte b = Convert.ToByte(number);

                Console.WriteLine(number);

            }
            catch (IndexOutOfRangeException bandymas)
            {
                Console.WriteLine("Ivyko klaida, uz masyvo ribu " + bandymas);
            }
            catch (FormatException bandymas1)
            {
                Console.WriteLine("Ivestas blogas tekstas " + bandymas1);
                throw; // perduoti 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();
        }
    }
}
