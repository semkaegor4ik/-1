using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace прога1
{
    class Program
    {
        static void Main()
        {
            char[] delimiterChars = { ' ', '\n' };
            string temp;
            List<Client> clients = new List<Client>();
            using (StreamReader input = new StreamReader("input.txt"))
            {
                temp = input.ReadToEnd();
            }
            string[] info = temp.Split(delimiterChars);
            for(int i=0; i<info.Length;)
            {
                DateTime b = new DateTime(int.Parse(info[i + 1]), int.Parse(info[i + 2]), int.Parse(info[i + 3]));
                if (info[i] == "Vkladchik")
                {
                    Vkladchik a = new Vkladchik(b, info[i + 4], int.Parse(info[i + 5]), int.Parse(info[i + 6]));
                    clients.Add(a);
                    i += 7;
                }
                else if (info[i] == "Kreditor")
                {
                    Kreditor a = new Kreditor(b, info[i + 4], int.Parse(info[i + 5]), int.Parse(info[i + 6]), int.Parse(info[i + 7]));
                    clients.Add(a);
                    i += 8;
                }
                else if (info[i] == "Organizacia")
                {
                    Organizacia a = new Organizacia(b, info[i + 4], int.Parse(info[i + 5]), int.Parse(info[i + 6]));
                    clients.Add(a);
                    i += 7;
                }
                else
                    i++;
            }
            Console.WriteLine("полный список клиентов:");
            foreach (Client elem in clients)
            {
                elem.ShowInfo();
            }
            int y,m,d;
            Console.WriteLine("Введите дату для поиска: год, месяц, день");
            y = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(y, m, d);
            Console.WriteLine("Клиенты, которые начали сотрубничать с банком с заданной даты:");
            bool flag = true;
            foreach (Client elem in clients)
            {
                if (elem.Opendata == data)
                {
                    flag = false;
                    Console.WriteLine(elem.call);
                }
            }
            if(flag)
                Console.WriteLine("Таких клиентов нету");
            clients.Sort();
            Console.WriteLine("отсортированный по дате список клиентов:");
            foreach (Client elem in clients)
            {
                elem.ShowInfo();
            }
        }
    }
}