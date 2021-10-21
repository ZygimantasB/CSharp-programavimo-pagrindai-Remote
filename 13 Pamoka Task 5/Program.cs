using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13_Pamoka_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdf asdf asdf asdf ";
            string[] manoeilutes = { s, "aasdfasd asdfas", "asdfasd" };
            if (Directory.Exists(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas") == false)
            {
                Console.WriteLine(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas");
            }

            Directory.CreateDirectory(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas");

            //var steam = File.Create(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas");
            //steam.Close();

            //File.AppendAllLines(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas", manoeilutes);

            if (File.Exists(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas"))
            {
                File.Delete(@"G:\My Drive\C Sharp mokymai video\Paskaitos video\13 Pamoka\Failu sukurimas");
            }

        }
    }
}
