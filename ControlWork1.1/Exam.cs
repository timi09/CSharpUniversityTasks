using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1._1
{
    internal class Exam : IComparable<Exam>, IComparer<Exam>
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public DateTime Date  { get; set; }

        public Exam(string name, int mark, DateTime date)
        {
            Name = name;
            Mark = mark;
            Date = date;
        }

        public Exam()
        {
            Name = "Название экзамена";
            Mark = 5;
            Date = DateTime.MinValue;
        }

        public override string ToString()
        {
            return $"Экзамен: {Name}, отметка: {Mark}, дата: {Date.ToString("dd.MM.yyyy")}"; 
        }

        public int CompareTo(Exam? exam)
        {
            if (exam == null)
                throw new ArgumentNullException("Экзамен для сравнения не может быть null");

            return this.Name.CompareTo(exam.Name);
        }

        public int Compare(Exam? x, Exam? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Экзамены для сравнения не могут быть null");

            return x.Mark - y.Mark;
        }
    }

    internal class ExamDateComparer : IComparer<Exam>
    {
        public int Compare(Exam? x, Exam? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Экзамены для сравнения не могут быть null");

            return DateTime.Compare(x.Date, y.Date);
        }
    }
}
