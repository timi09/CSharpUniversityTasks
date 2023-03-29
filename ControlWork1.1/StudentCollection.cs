using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlWork1._1
{
    delegate TKey KeySelector<TKey>(Student student);

    internal class StudentCollection<TKey> where TKey : notnull
    {
        private Dictionary<TKey, Student> Students;
        private KeySelector<TKey> KeySelector;

        public double MaxAverageMark
        {
            get
            {
                return Students.Values.Max(student => student.AverageMark);
            }
        }

        public StudentCollection(KeySelector<TKey> func)
        {
            KeySelector = func;
            Students = new Dictionary<TKey, Student>();
        }

        public void AddDefaults()
        {
            var Evgeniy = new Person("Евгений", "Тихонов", new DateTime(2001, 12, 9));
            var Danya = new Person("Данила", "Овеченко", new DateTime(2002, 6, 16));
            var Sasha = new Person("Александр", "Разиньков", new DateTime(2002, 10, 11));

            var education = new Education(EducationLevel.Undergraduate, EducationForm.FullTime, 3, true);

            #region Exams
            var EvgeniyExams = new List<Exam>
            {
                new Exam("ТФЯиТ", 4, new DateTime(2023, 1, 11)),
                new Exam("Теория вероятностей", 3, new DateTime(2023, 3, 20)),
                new Exam("Компьютерная графика", 4, new DateTime(2023, 1, 17))
            };

            var DanyaExams = new List<Exam>
            {
                new Exam("ТФЯиТ", 4, new DateTime(2023, 1, 11)),
                new Exam("Теория вероятностей", 5, new DateTime(2023, 1, 19)),
                new Exam("Компьютерная графика", 4, new DateTime(2023, 1, 17))
            };

            var SashaExams = new List<Exam>
            {
                new Exam("ТФЯиТ", 4, new DateTime(2023, 1, 11)),
                new Exam("Теория вероятностей", 4, new DateTime(2023, 1, 19)),
                new Exam("Компьютерная графика", 4, new DateTime(2023, 1, 17))
            };
            #endregion

            #region Tests
            var EvgeniyTests = new List<Test>
            {
                new Test("Физика", "не сдано", new DateTime(2023, 3, 20)),
                new Test("Английский", "сдано", new DateTime(2023, 1, 21)),
                new Test("Методы вычисления", "не сдано", new DateTime(2023, 3 , 15))
            };

            var DanyaTests = new List<Test>
            {
                new Test("Физика", "сдано", new DateTime(2023, 1 ,13)),
                new Test("Английский", "сдано", new DateTime(2023, 1, 21)),
                new Test("Методы вычисления", "сдано", new DateTime(2023, 3, 22))
            };

            var SashaTests = new List<Test>
            {
                new Test("Физика", "сдано", new DateTime(2023, 1 ,13)),
                new Test("Английский", "сдано", new DateTime(2023, 1, 21)),
               new Test("Методы вычисления", "не сдано", new DateTime(2023, 3 , 15))
            };
            #endregion

            AddStudents(new Student[]
            {
                new Student(Evgeniy, education, 313, EvgeniyExams, EvgeniyTests),
                new Student(Danya, education, 313, DanyaExams, DanyaTests),
                new Student(Sasha, education, 313, SashaExams, SashaTests)
            });
        }

        public void AddStudents(params Student[] students)
        {
            foreach (var student in students)
            {
                TKey key = KeySelector(student);
                Students[key] = student;
            }
        }

        public IEnumerable<KeyValuePair<TKey, Student>> WhereEducation(Education education)
        {
            return Students.Where(pair => pair.Value[education]);
        }

        public IEnumerable<IGrouping<Education, KeyValuePair<TKey, Student>>> EducationGroups
        {
            get
            {
                return Students.GroupBy(pair => pair.Value.Education);
            }
        }

        public IEnumerable<IGrouping<double, KeyValuePair<TKey, Student>>> AverageMarkGroups
        {
            get
            {
                return Students.GroupBy(pair => pair.Value.AverageMark);
            }
        }

        public List<Student> Sort(IComparer<Student> comparer) 
        {
            var students = Students.Values.ToList();
            students.Sort(comparer);
            return students;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var keyStudentPair in Students)
            {
                str += "{\n" +
                    $"\t{keyStudentPair.Key}:\n" +
                    $"\t\t{keyStudentPair.Value.ToString().Replace("\n", "\n\t\t")}\n" +
                    "},\n"; 
            }

            str = str.Remove(str.Length-2);

            return $"[\n" +
                $"\t{str.Replace("\n", "\n\t")}\n" +
                $"]"; 
        }

        public virtual string ToShortString()
        {
            string str = "";
            foreach (var keyStudentPair in Students)
            {
                str += "{\n" +
                    $"\t{keyStudentPair.Key}:\n" +
                    $"\t\t{keyStudentPair.Value.ToShortString().Replace("\n", "\n\t\t")}\n" +
                    "},\n";
            }

            str = str.Remove(str.Length - 2);

            return $"[\n" +
                $"\t{str.Replace("\n", "\n\t")}\n" +
                $"]";
        }
    }

    internal class StudentLastNameComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            return x.Person.LastName.CompareTo(y.Person.LastName);
        }
    }
    internal class StudentDateOfBirthComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            return x.Person.DateofBirth.CompareTo(y.Person.DateofBirth);
        }
    }

    internal class StudentAverageMarkComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            return x.AverageMark.CompareTo(y.AverageMark);
        }
    }
}
