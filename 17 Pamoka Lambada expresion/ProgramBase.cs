namespace _17_Pamoka_Lambada_expresion
{
    internal class ProgramBase
    {

        public static List<string> FillStudetsList(List<Studentas> students)
        {
            for (int i = 0; i < 100; i++)
            {
                var stud = new Studentas($"Vardas {i}", i, new Random(i).Next(0, 100), i % 2 == 0, new Random(i).NextDouble(1, 11));
                students.Add(stud);

                return students;
            }
        }
        static void Main(string[] args)
        {
            List<Studentas> students = new List<Studentas>();
            FillStudetsList(students);

            var geriStudentai = students.FindAll(s => s.AverangeMark > 8);
            students.Sort((s, o) =>
            {
                bool v = s.Age > o.Age;
                return v;
            });

            foreach (var item in geriStudentai)
            {
                Console.WriteLine($"{item.Name} {item.AverangeMark}");
            }

        }
    }
}