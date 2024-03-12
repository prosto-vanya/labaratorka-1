
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<students> listofstudents = new List<students>()
            {
                new students() { Name = "Ембер", surname = "Солончук", fathersName = "Буш", data = 2004, cours = 2, NumGroup = "ФМ-21", Mark1 = 85, Mark2 = 90, Mark3 = 100, Mark4 = 78, Mark5 = 61, },
                new students() { Name = "Марія", surname = "Джіна", fathersName = "Олеексіївна", data = 2005, cours = 1, NumGroup = "ФЛ-31", Mark1 = 62, Mark2 = 78, Mark3 = 75, Mark4 = 80, Mark5 = 91, },
                new students() { Name = "Олексій", surname = "Осадчій", fathersName = "Олексійович", data = 2005, cours = 1, NumGroup = "ФМ-31", Mark1 = 70, Mark2 = 100, Mark3 = 61, Mark4 = 68, Mark5 = 80, },
                new students() { Name = "Євгеній", surname = "Набока", fathersName = "Дмитрійович", data = 2003, cours = 2, NumGroup = "ФМ-21", Mark1 = 74, Mark2 = 81, Mark3 = 65, Mark4 = 70, Mark5 = 69, },
                new students() { Name = "Євгенія", surname = "Панченко", fathersName = "Віталіївна", data = 2003, cours = 1, NumGroup = "ФМ-31", Mark1 = 98, Mark2 = 100, Mark3 = 62, Mark4 = 78, Mark5 = 91, },
                new students() { Name = "Анастасія", surname = "Желестюк", fathersName = "Володимирівна", data = 2005, cours = 1, NumGroup = "ФЛ-31", Mark1 = 95, Mark2 = 98, Mark3 = 72, Mark4 = 85, Mark5 = 100, },
                new students() { Name = "Катерина", surname = "Коноваленко", fathersName = "Сергіївна", data = 2004, cours = 2, NumGroup = "ФЛ-21", Mark1 = 73, Mark2 = 86, Mark3 = 91, Mark4 = 65, Mark5 = 86, },
                new students() { Name = "Іван", surname = "Гаран", fathersName = "Сергійович", data = 2005, cours = 1, NumGroup = "ФМ-31", Mark1 = 60, Mark2 = 69, Mark3 = 69, Mark4 = 69, Mark5 = 100, },
                new students() { Name = "Олексій", surname = "Зозуля", fathersName = "Олексійович", data = 2004, cours = 2, NumGroup = "ФМ-21", Mark1 = 96, Mark2 = 69, Mark3 = 96, Mark4 = 69, Mark5 = 80, },
                new students() { Name = "Анна", surname = "Сиротюк", fathersName = "Володимирівна", data = 2003, cours = 2, NumGroup = "ФЛ-21", Mark1 = 100, Mark2 = 99, Mark3 = 98, Mark4 = 97, Mark5 = 96, }, };
            listofstudents.Sort(CompareStudCours);
            listofstudents.Sort(CompareStusents);

            foreach (students s in listofstudents)
            {
                Console.WriteLine(s.Name + " " + s.surname + " " + s.fathersName + ", Курс - " + s.cours + ", Група - " + s.NumGroup);
                int serbal = (s.Mark5 + s.Mark2 + s.Mark3 + s.Mark4 + s.Mark1) / 5;
                Console.WriteLine("                      Середьня оцінка: " + serbal);
            };

            BestOcenkaGroup("ФМ-21", listofstudents);
            BestOcenkaGroup("ФМ-31", listofstudents);
            BestOcenkaGroup("ФЛ-21", listofstudents);
            BestOcenkaGroup("ФЛ-31", listofstudents);
            Console.ReadKey();
        }
        static void BestOcenkaGroup(string group, List<students> listofstudents)
        {
            int j = 0;
            int SR1 = 0;
            int SR3 = 0;
            int SR2 = 0;
            int SR4 = 0;
            int SR5 = 0;
            for (int i = 0; i < listofstudents.Count; i++)
            {
                if (listofstudents[i].NumGroup == group)
                {
                    SR1 = SR1 + listofstudents[i].Mark1;
                    SR2 = SR2 + listofstudents[i].Mark2;
                    SR3 = SR3 + listofstudents[i].Mark3;
                    SR4 = SR4 + listofstudents[i].Mark4;
                    SR5 = SR5 + listofstudents[i].Mark5;
                    j++;
                }
            }
            Console.WriteLine("Середня оцінка з предметів групи: " + group + " " + SR1/j + " " + SR2 / j + " " + SR3 / j + " " + SR4 / j + " " + SR5 / j);
        }
        static int CompareStudCours(students x, students y)
        {
            return x.Name.CompareTo(y.Name);
        }
        static int CompareStusents(students user1, students user2)
        {
            return user1.cours.CompareTo(user2.cours);
        }

        class students
        {
            public string Name { get; set; }
            public string surname { get; set; }
            public string fathersName { get; set; }
            public int data { get; set; }
            public int cours { get; set; }
            public string NumGroup { get; set; }
            public int Mark1 { get; set; }
            public int Mark2 { get; set; }
            public int Mark3 { get; set; }
            public int Mark4 { get; set; }
            public int Mark5 { get; set; }
        }
    }
}