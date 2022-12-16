using System;

namespace LabWork4
{
    class Safearray
    {
        readonly int LIMIT = 12;
        protected int[] Arr;

        public int getLimit()
        {
            return LIMIT;
        }

        public Safearray()
        {
            Arr = new int[LIMIT];
        }

        public int this[int n]
        {
            get
            {
                if ((n < 0) || (n >= LIMIT))
                {
                    Console.WriteLine("Ошибочный индекс!");
                    return 0;
                }
                else
                {
                    return Arr[n];
                }
            }
            set
            {
                if ((n < 0) || (n >= LIMIT))
                {
                    Console.WriteLine("Ошибочный индекс!");
                }
                else
                {
                    Arr[n] = value;
                }
            }
        }
    }
}