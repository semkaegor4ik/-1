using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прога1
{
    class Kreditor : Client
    {
        public int procent;
        public int size;
        public int ostatok;
        public Kreditor(DateTime Opendata, string call, int size, int procent,int ostatok)
        : base(Opendata, call)
        {
            this.size = size;
            this.procent = procent;
            this.ostatok = ostatok;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Кредитор: " +
                "Фамилия: {0} " +
                "Дата выдачи кредита: {1} " +
                "Размер кредита: {2} " +
                "Процент по кредиту: {3}% " +
                "Остаток долга: {4}", call, Opendata, size, procent,ostatok);
        }
        override public int Datatype()
        {
            return 1;               //выдача кредита
        }
    }
}
