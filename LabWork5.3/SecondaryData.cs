using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._3
{
    class SecondaryData : Data 
    {
        public List<DateTime> Dates { get; private set; }

        public SecondaryData(List<DateTime> dates)
        {
            Dates = dates;
            FilteredIndexes = Enumerable.Range(0, Dates.Count).ToList();
        }

        public override void Filter()
        {
            FilteredIndexes = new List<int>();
            for (int i = 0; i < Dates.Count; i++)
            {
                if (Dates[i].DayOfWeek != DayOfWeek.Saturday && Dates[i].DayOfWeek != DayOfWeek.Sunday)
                {
                    FilteredIndexes.Add(i);
                }
            };
        }

        public override void Save()
        {
            string path = Directory.GetCurrentDirectory() + @"\secondaryData_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

            using (var stream = File.CreateText(path))
            {
                stream.WriteLine(this);
            }
        }

        public override void Show()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var i in FilteredIndexes)
            {
                str += Dates[i].ToString("dd.MM.yyyy") + " ";
            }
            return str;
        }
    }
}
