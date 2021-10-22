using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Pamoka_lambada_expresion_mano_bandymas
{
    public class Students
    {
        public int ID;
        public string Name;
        public int Age;
        public string AverangeMark;
        public string IsGettingTuition;

        public Students (int id, string name, int age, string averangemark, string isgettingtuitio)
        {
            ID = id;
            Name = name;
            Age = age;
            AverangeMark = averangemark;
            IsGettingTuition = isgettingtuitio;
        }
    }
}
