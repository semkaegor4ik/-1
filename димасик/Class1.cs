using System;
using System.Linq;
using System.IO;
namespace Example
{
    class Data
    {
        public DateTime data;
        public Data(int y,int m,int d)
        {
            this.data = new DateTime(y, m, d);
        }
        public Data()
        {
            this.data = new DateTime(2010, 1, 1);
        }
        public void Show()
        {
            Console.WriteLine("год: {0}" +
                "месяц: {1}" +
                "день: {2}", data.Year, data.Month, data.Day);
        }
        public Data LastDay()
        {
            if (data.Day == 1)
            {
                if (data.Month == 1)
                {
                    return new Data(data.Year - 1, 12, 31);
                }
                else
                {
                    if (data.Month == 12 || data.Month == 10 || data.Month == 7 || data.Month == 5)
                        return new Data(data.Year - 1, data.Month - 1, 30);
                    else if (data.Month == 2 || data.Month == 4 || data.Month == 6 || data.Month == 8 || data.Month == 9 || data.Month == 11)
                        return new Data(data.Year - 1, data.Month - 1, 31);
                    else
                    {
                        if (data.Year % 4 == 2)
                            return new Data(data.Year - 1, data.Month - 1, 29);
                        else
                            return new Data(data.Year - 1, data.Month - 1, 28);
                    }
                }
            }
            else if (data.Month == 1)
                return new Data(data.Year - 1, 12, data.Day - 1);
            else
                return new Data(data.Year - 1, data.Month - 1, data.Day - 1);
        }
      
        public Data NextDay()
        {
            if(( data.Month == 4 ||data.Month == 6  ||data.Month == 9 ||data.Month == 11)&&(data.Day==30))
            {
                return new Data(data.Year , data.Month + 1, 1);
            }
            else if((data.Month == 1 || data.Month == 3 || data.Month == 5 || data.Month == 7 || data.Month == 8 || data.Month == 10) && (data.Day == 31))
            {
                return new Data(data.Year, data.Month + 1, 1);
            }
            else if(data.Month == 12 && data.Day==31)
            {
                return new Data(data.Year + 1, 1, 1);
            }
            else if (data.Month == 2)
            {
                if ((data.Year % 4 == 2) && (data.Day == 29))
                    return new Data(data.Year, data.Month + 1, 1);
                else if ((data.Year % 4 != 2) && (data.Day == 28))
                    return new Data(data.Year, data.Month + 1, 1);
                else
                    return new Data(data.Year, data.Month , data.Day + 1);
            }
            else
            {
                return new Data(data.Year, data.Month, data.Day + 1);
            }
        }
        public int EndMonth()
        {
            if (data.Month == 1 || data.Month == 3 || data.Month == 5 || data.Month == 7 || data.Month == 8 || data.Month == 10 || data.Month == 12)
                return 31 - data.Day;
            else if (data.Month == 4 || data.Month == 6 || data.Month == 9 || data.Month == 11)
                return 30 - data.Day;
            else if (data.Year % 4 == 2)
                return 29 - data.Day;
            else
                return 28 - data.Day;
        }
        public Data DAY
        {
            get
            {
                return new Data(data.Year, data.Month, data.Day);
            }
            set
            {
                this.data = value.data;
            }
        }
        public bool Visok
        {
            get
            {
                if (data.Year % 4 == 2)
                    return true;
                else
                    return false;
            }
        }
        public Data this[int c]
        {
            get
            {
                Data a = new Data(data.Year, data.Month, data.Day);
                if (c > 0)
                {
                    for (int i = 0; i < c; i++)
                    {
                         a = a.NextDay();
                    }
                    return a;
                }
                else if (c < 0)
                {
                    for (int i = 0; i < Math.Abs(c); i++)
                    {
                         a = a.LastDay();
                    }
                    return a;
                }
                else
                    return a;
            }
        }
        public static bool operator !(Data a)
        {
            if ((a.data.Month == 1 || a.data.Month == 3 || a.data.Month == 5 || a.data.Month == 7 || a.data.Month == 8 || a.data.Month == 10 || a.data.Month == 12) && (a.data.Day == 31))
                return false;
            else if ((a.data.Month == 4 || a.data.Month == 6 || a.data.Month == 9 || a.data.Month == 11) && (a.data.Day == 30))
                return false;
            else if ((a.data.Month == 2) && (a.data.Year % 4 == 2) && (a.data.Day == 29))
                return false;
            else if ((a.data.Month == 2) && (a.data.Year % 4 != 2) && (a.data.Day == 28))
                return false;
            else
                return true;
        }
        public static bool operator true(Data a)
        {
            if (a.data.Month == 1 && a.data.Day == 1)
                return true;
            else
                return false;
        }
        public static bool operator false(Data a)
        {
            if (a.data.Month == 1 && a.data.Day == 1)
                return false;
            else
                return true;
        }
        public static bool operator &(Data a, Data b)
        {
            if (a.data == b.data)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main()
        {
            Data[] ar = new Data[5];
            char[] delimiterChars = { ' ', '\n' };
            string line;
            using (StreamReader fileIn = new StreamReader("input2.txt"))
            {
                line = fileIn.ReadToEnd();
            }
            string[] info = line.Split(delimiterChars);
            for (int i = 0, k = 0; i < info.Length; i += 3, k++)
            {
                Data c = new Data(int.Parse(info[i]), int.Parse(info[i + 1]), int.Parse(info[i + 2]));
                ar[k] = c;
            }
            ar[0].Show();
            Data a = ar[0].LastDay();
            a.Show();
            a = ar[1].NextDay();
            a.Show();
            Console.WriteLine("До конца месяца {0} дня: {1} дней",ar[2].data,ar[2].EndMonth());
            if(ar[3].Visok)
            {
                Console.WriteLine("В дате {0} год является высокосным", ar[3].data);
            }
            else
            {
                Console.WriteLine("В дате {0} год  не является высокосным", ar[3].data);
            }
            ar[4].Show();
            a = ar[4][38];
            a.Show();
            if(!!ar[3])
            {
                Console.WriteLine("В дате {0} день последний в месяце", ar[3].data);
            }
            if(ar[0]&ar[1])
            {
                Console.WriteLine("{0} и {1} один и тот же день", ar[0].data, ar[1].data);
            }
            else
            {
                Console.WriteLine("{0} и {1} не один и тот же день", ar[0].data, ar[1].data);
            }
        }
    }
}