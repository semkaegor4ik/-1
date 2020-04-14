using System;
using System.Linq;
using System.IO;
namespace Example
{
    struct Student
    {
        public int course, group;
        public string secondname, facult;
        public int c1, c2, c3;
        public Student(string secondname, string facult, int course, int group, int c1, int c2, int c3)
        {
            this.secondname = secondname;
            this.facult = facult;
            this.course = course;
            this.group = group;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }
    }


    class Program
    {
        static void Show(Student[] a)
        {
            using (StreamWriter fileOut = new StreamWriter("output.txt", false))
            {
                var san = a.Where(n => (n.c1 == 2) || (n.c2 == 2) || (n.c3 == 2)).OrderBy(n => n.facult).
                    GroupBy(n => n.facult);
                foreach (var group in san)
                {
                    fileOut.WriteLine("Факультет: {0}", group.Key);
                    foreach (var item in group)
                    {
                        fileOut.Write("Фамилия: {0} ", item.secondname);
                        fileOut.Write("Факультет {0} ", item.facult);
                        fileOut.Write("Курс {0} ", item.course);
                        fileOut.Write("Группа {0} ", item.group);
                        fileOut.WriteLine("Оценки :{0},{1},{2}", item.c1, item.c2, item.c3);
                    }
                }
            }
        }
        static void Main()
        {
            char[] delimiterChars = { ' ', '\n' };
            string line;
            using (StreamReader fileIn = new StreamReader("input3.txt"))
            {
                line = fileIn.ReadToEnd(); 
            }
            string[] info = line.Split(delimiterChars);
            Student[] a = new Student[info.Length / 7];

            int k = 0;
            Student b;
            for (int i = 0; i < info.Length - 6; i += 7)
            {
                b.secondname = info[i];
                b.facult = info[i + 1];
                b.course = int.Parse(info[i + 2]);
                b.group = int.Parse(info[i + 3]);
                b.c1 = int.Parse(info[i + 4]);
                b.c2 = int.Parse(info[i + 5]);
                b.c3 = int.Parse(info[i + 6]);
                a[k] = b;
                k++;
            }
            Show(a);
        }
    }
}