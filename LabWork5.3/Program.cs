using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var signalData = new SignalData(new List<int>() {15, 48, -3, 87, 155, 20});
            var secondData = new SecondaryData(new List<DateTime>()
            {
                new DateTime(2022, 12, 23), //четверг
                new DateTime(2022, 12, 24), //пятница
                new DateTime(2022, 12, 25), //суббота
                new DateTime(2022, 12, 26), //воскресенье
                new DateTime(2022, 12, 27), //понедельник
                new DateTime(2022, 12, 28) //вторник
            });

            signalData.Filter();
            signalData.Save();
            signalData.Show();

            secondData.Filter();
            secondData.Save();
            secondData.Show();

            ResultData resultData = new ResultData(signalData, secondData);

            resultData.Filter();
            resultData.Save();
            resultData.Show();
        }
    }
}
