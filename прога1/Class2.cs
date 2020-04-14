using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прога1
{

    class Vkladchik : Client
    {
        public int size;
        public int procent;
        public Vkladchik(DateTime Opendata, string call, int size, int procent)
        : base(Opendata, call)
        {
            this.size = size;
            this.procent = procent;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Вкладчик: " +
                "Фамилия: {0} " +
                "Дата открытие вклада: {1} " +
                "Размер вклада: {2} " +
                "Процент по вкладу: {3}%",call,Opendata,size,procent);
        }
        override public int Datatype()
        {
            return 0;               //открытие вклада
        }
       
    }
}
