using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlWork1._1
{
    internal class Test : IComparable<Test>, IComparer<Test>
    {
        public string Name { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }

        public Test(string name, string result, DateTime date)
        {
            Name = name;
            Result = result;
            Date = date;
        }

        public Test()
        {
            Name = "Название заета";
            Result = "сдано";
            Date = DateTime.MinValue;
        }

        public override string ToString()
        {
            return $"Зачет: {Name}, результат: {Result}, дата: {Date.ToString("dd.MM.yyyy")}";
        }

        public int CompareTo(Test? test)
        {
            if (test == null)
                throw new ArgumentNullException("Зачет для сравнения не могжет быть null");

            return this.Name.CompareTo(test.Name);
        }

        public int Compare(Test? x, Test? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Зачеты для сравнения не могут быть null");

            return string.Compare(x.Result, y.Result);
        }
    }

    internal class TestDateComparer : IComparer<Test>
    {
        public int Compare(Test? x, Test? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Зачеты для сравнения не могут быть null");

            return DateTime.Compare(x.Date, y.Date);
        }
    }
}
