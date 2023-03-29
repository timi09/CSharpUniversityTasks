using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1
{
    internal class Frequency
    {
        public int Count { get; set; }
        public int DaysPeriod { get; set; }

        public Frequency(int count, int days)
        {
            Count = count;
            DaysPeriod = days;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Frequency) 
            {
                Frequency frequency2 = obj as Frequency;

                if ((float)Count/DaysPeriod == (float)frequency2.Count/frequency2.DaysPeriod)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Count} раз в {DaysPeriod} дней";
        }
    }
}
