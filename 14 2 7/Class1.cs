using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
class Program
{

    struct Toy : IComparable<Toy>
    {

        public int yearup, yeardown, cost;
        public string name;
        public Toy(string name, int cost, int yeardown, int yearup)
        {
            this.name = name;
            this.cost = cost;
            this.yeardown = yeardown;
            this.yearup = yearup;
        }
        public int CompareTo(Toy obj)
        {
            if (this.cost == obj.cost) // типа SPoint проводилось по возрастанию
            { ///расстоянию от точки до начала координат
                return 0;
            }
            else
            {
                if (this.cost > obj.cost)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    static void Show(Toy[] a, int n, int m)
    {
        using (StreamWriter fileOut = new StreamWriter("output.txt", false))
        {
            foreach (Toy b in a)
            {
                if ((b.yeardown <= n) && (b.yearup >= m))
                {
                    fileOut.Write("Название: {0} ", b.name);
                    fileOut.Write("Цена {0} ", b.cost);
                    fileOut.WriteLine("Возрастное ограничение {0}-{1}", b.yeardown, b.yearup);
                }
            }
        }
    }
    static void Show(Toy[] a)
    {
        using (StreamWriter fileOut = new StreamWriter("output1.txt", false))
        {
            foreach (Toy b in a)
            {
                
                    fileOut.Write("Название: {0} ", b.name);
                    fileOut.Write("Цена {0} ", b.cost);
                    fileOut.WriteLine("Возрастное ограничение {0}-{1}", b.yeardown, b.yearup);
                
            }
        }
    }
    static int Main()
    {
        char[] delimiterChars = { ' ', '\n' };
        string line;
        using (StreamReader fileIn = new StreamReader("input1.txt"))
        {
            line = fileIn.ReadToEnd(); ;
        }
        string[] info = line.Split(delimiterChars);
        Toy[] a = new Toy[info.Length / 4];

        int k = 0;
        Toy b;
        for (int i = 0; i < info.Length - 3; i += 4)
        {
            b.name = info[i];
            b.cost = int.Parse(info[i + 1]);
            b.yeardown = int.Parse(info[i + 2]);
            b.yearup = int.Parse(info[i + 3]);
            a[k] = b;
            k++;
        }
        Console.WriteLine("Введи возрасnные границы для поиска игрушек");
        int n1 = int.Parse(Console.ReadLine());
        int m1 = int.Parse(Console.ReadLine());
        int n, m;
        if (n1 > m1)
        {
            n = m1;
            m = n1;
        }
        else
        {
            n = n1;
            m = m1;
        }
        Array.Sort(a);
        Show(a);
        Show(a, n, m);
        return 0;
    }
}