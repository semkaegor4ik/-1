using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_СЕМ_21_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', '\n' };
            string line;
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                line = fileIn.ReadToEnd();
            }
            string[] info = line.Split(delimiterChars);

            BinaryTree a = new BinaryTree();
            foreach (string elem in info)
                a.Add(elem);
            int n = a.ChetValue();
            Console.WriteLine("Количество четных элементов в дереве:{0}", n);
            // n = a.Kolvo();
            //Console.WriteLine("Количество элементов для добавления в дерево до сбалансированного:{0},{1},{2}", n-1,n,n+1);
        }
    }
}
