using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2Сем_21_2_15
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
            
        }
    }
}
