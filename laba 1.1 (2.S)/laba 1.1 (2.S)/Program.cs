
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
            }
            int SBФМ211 = 0;
            int SBФМ311 = 0;
            int SBФЛ211 = 0;
            int SBФЛ311 = 0;
            int SBФМ212 = 0;
            int SBФМ312 = 0;
            int SBФЛ212 = 0;
            int SBФЛ312 = 0;
            int SBФМ213 = 0;
            int SBФМ313 = 0;
            int SBФЛ213 = 0;
            int SBФЛ313 = 0;
            int SBФМ214 = 0;
            int SBФМ314 = 0;
            int SBФЛ214 = 0;
            int SBФЛ314 = 0;
            int SBФМ215 = 0;
            int SBФМ315 = 0;
            int SBФЛ215 = 0;
            int SBФЛ315 = 0;
            int clw1 = 0;
            int clw2 = 0;
            int clw3 = 0;
            int clw4 = 0;

            for (int i = 0; i < listofstudents.Count; i++)
            {
                for (int j = 0; j < listofstudents.Count; j++)
                {
                    if (listofstudents[i].NumGroup == "ФМ-31" && listofstudents[j].NumGroup == "ФМ-31")
                    {
                        SBФМ311 = SBФМ311 + listofstudents[i].Mark1;
                        SBФМ312 = SBФМ312 + listofstudents[i].Mark2;
                        SBФМ313 = SBФМ313 + listofstudents[i].Mark3;
                        SBФМ314 = SBФМ314 + listofstudents[i].Mark4;
                        SBФМ315 = SBФМ315 + listofstudents[i].Mark5;
                        clw1++;
                    }
                    if (listofstudents[i].NumGroup == "ФЛ-31" && listofstudents[j].NumGroup == "ФЛ-31")
                    {
                        SBФЛ311 = SBФЛ311 + listofstudents[i].Mark1;
                        SBФЛ312 = SBФЛ312 + listofstudents[i].Mark2;
                        SBФЛ313 = SBФЛ313 + listofstudents[i].Mark3;
                        SBФЛ314 = SBФЛ314 + listofstudents[i].Mark4;
                        SBФЛ315 = SBФЛ315 + listofstudents[i].Mark5;
                        clw2++;
                    }
                    if (listofstudents[i].NumGroup == "ФЛ-21" && listofstudents[j].NumGroup == "ФЛ-21")
                    {
                        SBФЛ211 = SBФЛ211 + listofstudents[i].Mark1;
                        SBФЛ212 = SBФЛ212 + listofstudents[i].Mark2;
                        SBФЛ213 = SBФЛ213 + listofstudents[i].Mark3;
                        SBФЛ214 = SBФЛ214 + listofstudents[i].Mark4;
                        SBФЛ215 = SBФЛ215 + listofstudents[i].Mark5;
                        clw3++;
                    }
                    if (listofstudents[i].NumGroup == "ФМ-21" && listofstudents[j].NumGroup == "ФМ-21")
                    {
                        SBФМ211 = SBФМ211 + listofstudents[i].Mark1;
                        SBФМ212 = SBФМ212 + listofstudents[i].Mark2;
                        SBФМ213 = SBФМ213 + listofstudents[i].Mark3;
                        SBФМ214 = SBФМ214 + listofstudents[i].Mark4;
                        SBФМ215 = SBФМ215 + listofstudents[i].Mark5;
                        clw4++;
                    }
                }

            }

            Winer(SBФМ311, SBФЛ311, SBФЛ211, SBФМ211, clw1, clw2, clw3, clw4);
            Winer(SBФМ312, SBФЛ312, SBФЛ212, SBФМ212, clw1, clw2, clw3, clw4);
            Winer(SBФМ313, SBФЛ313, SBФЛ213, SBФМ213, clw1, clw2, clw3, clw4);
            Winer(SBФМ314, SBФЛ314, SBФЛ214, SBФМ214, clw1, clw2, clw3, clw4);
            Winer(SBФМ315, SBФЛ315, SBФЛ215, SBФМ215, clw1, clw2, clw3, clw4);

            Console.ReadKey();
        }
        static int CompareStudCours(students x, students y)
        {
            return x.Name.CompareTo(y.Name);
        }
        static int CompareStusents(students user1, students user2)
        {
            return user1.cours.CompareTo(user2.cours);
        }
        static void Winer(int h, int k, int g, int f, int clw1, int clw2, int clw3, int clw4)
        {
            if (h / clw1 > k / clw2 && h / clw1 > g / clw3 && h / clw1 > f / clw4)
            {
                Console.WriteLine(h / clw1);
            }
            if (k / clw2 > h / clw1 && k / clw2 > g / clw3 && k / clw2 > f / clw4)
            {
                Console.WriteLine(k / clw2);
            }
            if (g / clw3 > k / clw2 && g / clw3 > h / clw1 && g / clw3 > f / clw4)
            {
                Console.WriteLine(g / clw3);
            }
            if (f / clw4 > k / clw2 && f / clw4 > g / clw3 && f / clw4 > h / clw1)
            {
                Console.WriteLine(f / clw4);
            }
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