using System;
using System.Linq;
using System.IO;
namespace Example
{
    class Program
    {
        static void Main()
        {
            char[] delimiterChars = { ' ', '\n' };
            string line;
            //получение источника данных
            using (StreamReader fileIn = new StreamReader("input2.txt"))
            {
                line = fileIn.ReadToEnd();
            }
            string[] info = line.Split(delimiterChars);
            int c = info.Length;
            int[] a = new int[c];
            for (int i = 0; i < c; i++)
            {
                a[i] = int.Parse(info[i]);
            }
            var files =
                from n in a
                where n < 0
                orderby n
                select -n;
            //выполнение запроса
            using (StreamWriter fileOut = new StreamWriter("output.txt", false))
                foreach (var x in files)
                {
                    fileOut.WriteLine("{0}", x);
                }
        }
    }
}