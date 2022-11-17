using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    class Safehilo : Safearray
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public Safehilo(int start, int end) : base()
        {
            this.Start = start;
            this.End = end;
        }

        public int this[int n]
        {
            get
            {
                if (n < 0 || n > getLimit())
                {
                    return base[n];
                }
                else if (n < Start)
                {
                    Console.WriteLine("Индекс меньше левой границы!");
                    return 0;
                }
                else if (n > End)
                {
                    Console.WriteLine("Индекс больше правой границы!");
                    return 0;
                }
                else
                {
                    return Arr[n];
                }
            }
            set
            {
                if ((n < 0) || (n > getLimit()))
                {
                    base[n] = value;
                }
                else if (n < Start)
                {
                    Console.WriteLine("Индекс меньше левой границы!");
                }
                else if (n > End)
                {
                    Console.WriteLine("Индекс больше правой границы!");
                }
                else
                {
                    Arr[n] = value;
                }
            }
        }
    }
}
