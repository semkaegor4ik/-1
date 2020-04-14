using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прога1
{
    class Organizacia : Client
    {
        public int number;
        public int sum;
        public Organizacia(DateTime Opendata, string call, int number, int sum)
        : base(Opendata, call)
        {
            this.sum = sum;
            this.number = number;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Организация: " +
                "Название организации: {0} " +
                "Дата открытия счета: {1} " +
                "Номер счета: {2} " +
                "Сумматна счету: {3}", call, Opendata, number, sum);
        }
        override public int Datatype()
        {
            return 2;               //открытие счета
        }
    }
}
