using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прога1
{
    abstract class Client: IComparable<Client>
    {
        abstract public void ShowInfo();
        abstract public int Datatype();
        public DateTime Opendata;
        public string call;
        protected Client(DateTime Opendata, string call)
        {
            this.Opendata = Opendata;
            this.call = call;
        }
        public int CompareTo(Client temp)
        {

            if (this.Opendata > temp.Opendata)
                return 1;
            else
            {
                if (this.Opendata == temp.Opendata)
                    return 0;
                else
                    return -1;
            }
        }

    }
}
