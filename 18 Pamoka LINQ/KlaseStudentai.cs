using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Pamoka_LINQ
{
    class KlaseStudentai
    {
        public int ID;
        public string Name;
        public int Age;
        public double AvarageMark;
        public bool IsGettingTuition;

        public KlaseStudentai(int id, string name, int age, double avarangeMark, bool isgettingTuition)
        {
            ID = id;
            Age = age;
            Name = name;
            AvarageMark = avarangeMark;
            IsGettingTuition = isgettingTuition;
        }
        public void ManoSarasas(int id, string name, string averangeMark, bool isgettingTuition)
        {
            Console.WriteLine($"{id}, {name}, {averangeMark}, {isgettingTuition}");
        }
    }
}
