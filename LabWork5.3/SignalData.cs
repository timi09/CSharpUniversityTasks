using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._3
{
    class SignalData : Data
    {
        public List<int> SignalLevels { get; private set; }

        public SignalData(List<int> signalLevels)
        {
            SignalLevels = signalLevels;
            FilteredIndexes = Enumerable.Range(0, SignalLevels.Count).ToList();
        }

        public override void Filter()
        {
            FilteredIndexes = new List<int>();
            for (int i = 0; i < SignalLevels.Count; i++)
            {
                if (SignalLevels[i] >= 0 && SignalLevels[i] <= 100)
                {
                    FilteredIndexes.Add(i);
                }
            }
        }

        public override void Save()
        {
            string path = Directory.GetCurrentDirectory() + @"\signalData_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

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
                str += SignalLevels[i] + " ";
            }
            return str;
        }
    }
}
