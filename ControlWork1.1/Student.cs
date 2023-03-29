using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ControlWork1._1
{
    internal class Student
    {
        public Person Person { get; private set; }
        public Education Education { get; private set; }
        public int GroupNumber { get; private set; }
        public List<Exam> Exams { get; private set; }
        public List<Test> Tests { get; private set; }

        public double AverageMark 
        {
            get 
            { 
                if (Exams.Count == 0)
                    return 0;
                return Exams.Average(exam => exam.Mark); 
            } 
        }

        public bool this[Education education]
        {
            get { return this.Education.Equals(education); }
        }

        public Student(Person person, Education education, int groupNumber, List<Exam> exams, List<Test> tests)
        {
            Person = person;
            Education = education;
            GroupNumber = groupNumber;
            Exams = exams;
            Tests = tests;
        }

        public Student(Person person, Education education, int groupNumber) : this(person, education, groupNumber, new List<Exam>(), new List<Test>())
        {
            //
        }

        public void AddExams(params Exam[] exams) 
        {
            Exams.AddRange(exams);
        }

        public void AddTests(params Test[] tests)
        {
            Tests.AddRange(tests);
        }

        public void SortExamsByName() 
        {
            Exam[] exams = Exams.ToArray();
            Array.Sort(exams); // перевод в массив для использования сравнения IComparable.CompareTo() класса Exam
            Exams = exams.ToList();
        }

        public void SortExamsByMark()
        {
            Exams.Sort(); // использования дефолтного сравнения IComparer.Compare() класса Exam
            //тождественно
            //Exams.Sort(new Exam());
        }

        public void SortExamsByDate()
        {
            Exams.Sort(new ExamDateComparer()); // использования сравнения IComparer.Compare() класса ExamDateComparer
        }

        public void SortTestsByName()
        {
            Test[] tests = Tests.ToArray();
            Array.Sort(tests); // перевод в массив для использования сравнения IComparable.CompareTo() класса Test
            Tests = tests.ToList();
        }

        public void SortTestsByMark()
        {
            Tests.Sort(); // использования дефолтного сравнения IComparer.Compare() класса Test
            //тождественно
            //Tests.Sort(new Test());
        }

        public void SortTestsByDate()
        {
            Tests.Sort(new TestDateComparer()); // использования сравнения IComparer.Compare() класса TestDateComparer
        }

        public override string ToString()
        {
            return $"Студент: {Person},\n" +
                $"Образование: {Education},\n" +
                $"Экзамены:\n" +
                $"[\n" +
                $"\t{string.Join(",\n\t", Exams)}\n" +
                $"],\n" +
                $"Зачеты:\n" +
                $"[\n" +
                $"\t{string.Join(",\n\t", Tests)}\n" +
                $"]";
        }

        public virtual string ToShortString()
        {
            return $"Студент: {Person},\n" +
                $"Образование: {Education},\n" +
                $"Средняя оценка: {AverageMark},\n" +
                $"Количество зачетов: {Tests.Count},\n" +
                $"Количество экзаменов: {Exams.Count}";
        }
    }
}
