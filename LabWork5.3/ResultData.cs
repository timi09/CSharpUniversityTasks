using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._3
{
    class ResultData : Data
    {
        public SignalData SignalData { get; private set; }
        public SecondaryData SecondaryData { get; private set; }

        public ResultData(SignalData signalData, SecondaryData secondaryData)
        {
            if (signalData.SignalLevels.Count != secondaryData.Dates.Count)
                throw new Exception("Данные должны содержать равное количество значений");

            SignalData = signalData;
            SecondaryData = secondaryData;
            FilteredIndexes = Enumerable.Range(0, signalData.SignalLevels.Count).ToList();
        }

        public override void Filter()
        {
            SignalData.Filter();
            SecondaryData.Filter();
            FilteredIndexes = SignalData.FilteredIndexes.Intersect(SecondaryData.FilteredIndexes).ToList();
        }

        public override void Save()
        {
            string path = Directory.GetCurrentDirectory() + @"\resultData_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";

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
                str += "{ "+SignalData.SignalLevels[i] + ": " + SecondaryData.Dates[i].ToString("dd.MM.yyyy") + "} ";
            }
            return str;
        }
    }
}
