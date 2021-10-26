using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Pamoka_LINQ
{
    class Program
    {
        public static bool IsGettingTuition { get; private set; }

        static void Main(string[] args)
        {
            KlaseStudentai manoStudentai1 = new KlaseStudentai(456789, "Linas", 45, 1, true);
            KlaseStudentai manoStudentai2 = new KlaseStudentai(78945, "Tomas", 89, 8, true);
            KlaseStudentai manoStudentai3 = new KlaseStudentai(741258, "Gerda", 24, 10, true);
            KlaseStudentai manoStudentai4 = new KlaseStudentai(965874, "Lina", 87, 9, true);
            KlaseStudentai manoStudentai5 = new KlaseStudentai(741258, "Faustas", 36, 4, true);

            List<KlaseStudentai> studentuList = new List<KlaseStudentai>();
            studentuList.Add(manoStudentai1);
            studentuList.Add(manoStudentai2);
            studentuList.Add(manoStudentai3);
            studentuList.Add(manoStudentai4);
            studentuList.Add(manoStudentai5);

            var rezultatai1 = studentuList.Where(s => s.Age > 21).ToList<KlaseStudentai>();
            var rezultatai2 = studentuList.Where(s => s.AvarageMark > 8 && s.IsGettingTuition == true).ToList<KlaseStudentai>();
            var rezultatai3 = studentuList.Where(s => s.AvarageMark < 4 && s.Name.Length < 8).ToList<KlaseStudentai>();

            //rezultatai1.ForEach(s => { Console.WriteLine(s.Name); Console.WriteLine(s.Age); Console.WriteLine(s.AvarageMark); Console.WriteLine(s.IsGettingTuition); });
            rezultatai2.ForEach(s => { Console.WriteLine("Studento ID: " + s.ID); Console.WriteLine("Studento vardas: " + s.Name) ; Console.WriteLine("Ar gauna studentas parama: " + (s.IsGettingTuition == true)); Console.WriteLine("Studento vidurkis daugiau nei 8: " + (s.AvarageMark > 8)); });
            Console.WriteLine("---------------------------------- Kita užduotis");
            rezultatai3.ForEach(s => { Console.WriteLine("Studento ID: " + s.ID); Console.WriteLine("Studento vardas: " + s.Name); Console.WriteLine("Ar pažymio vidurkis daugaiu nei 4: " + (s.AvarageMark < 4)); Console.WriteLine("Studento vardo ilgis: " + (s.Name.Length > 8)); });

            Console.ReadLine();
        }
    }
}
