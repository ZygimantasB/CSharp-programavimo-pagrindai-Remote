using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Pamoka_Lambada_expresion
{
    public class Studentas
    {
        public string Name;
        public int ID;
        public double Age;
        public double AverangeMark;
        public string IsGettingTuition;

        public Studentas (int iD, string name, int age, int averangemark, string isgettingtuition)
        {
            ID = iD;
            Name = name;
            Age = age;
            AverangeMark = averangemark;
            IsGettingTuition = isgettingtuition;
        }

        public Studentas(string v1, int i, int v2, bool v3, double v4)
        {
            V1 = v1;
            I = i;
            V2 = v2;
            V3 = v3;
            V4 = v4;
        }

        public string V1 { get; }
        public int I { get; }
        public int V2 { get; }
        public bool V3 { get; }
        public double V4 { get; }
    }
}
