namespace ControlWork1._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1. Создать объект типа StudentCollection. Добавить в коллекцию
            //несколько разных элементов типа Student и вывести объект StudentCollection.

            KeySelector<string> keySelectorFunc = delegate (Student student) { return student.Person.LastName; };

            StudentCollection<string> studentCollection = new StudentCollection<string>(keySelectorFunc);

            studentCollection.AddDefaults();

            var Ivan = new Person("Иван", "Иванов", new DateTime(2002, 1, 1));
            var IvanEducation = new Education(EducationLevel.Undergraduate, EducationForm.PartTime, 2, false);
            var IvanExams = new List<Exam>
            {
                new Exam("ТФЯиТ", 4, new DateTime(2023, 1, 11)),
                new Exam("Теория вероятностей", 5, new DateTime(2023, 1, 19)),
                new Exam("Компьютерная графика", 4, new DateTime(2023, 1, 17))
            };

            studentCollection.AddStudents(new Student(Ivan, IvanEducation, 213, IvanExams, new List<Test>()));

            Console.WriteLine("1. Объект StudentCollection");
            Console.WriteLine(studentCollection.ToString());




            //2. Для созданного объекта StudentCollection вызвать методы,
            //выполняющие сортировку списка List<Student> по фамилии, по дате рождения, по среднему баллу.

            Console.WriteLine("\n2. Для созданного объекта StudentCollection вызвать методы сортировки");
            
            Console.WriteLine("\nСортиовка по фамилии");
            var students = studentCollection.Sort(new StudentLastNameComparer());
            foreach (var student in students)
                Console.WriteLine("\n" + student.ToShortString());

            Console.WriteLine("\nСортиовка по дате рождения");
            students = studentCollection.Sort(new StudentDateOfBirthComparer());
            foreach (var student in students)
                Console.WriteLine("\n" + student.ToShortString());

            Console.WriteLine("\nСортиовка по среднему баллу");
            students = studentCollection.Sort(new StudentAverageMarkComparer());
            foreach (var student in students)
                Console.WriteLine("\n" + student.ToShortString());




            //3. Вызвать методы класса StudentCollection, выполняющие операции со
            //списком List<Student>, и после каждой операции вывести результат.

            Console.WriteLine("\n3. Операции со списком List<Student>");


            //Вычисление максимального значения среднего балла
            double mark = studentCollection.MaxAverageMark;
            Console.WriteLine("\nМаксимальное значение среднего балла = " + mark);



            //Фильтрация списка для отбора студентов с формой обучения
            var education1 = new Education(EducationLevel.Undergraduate, EducationForm.FullTime, 3, true);
            Console.WriteLine("\nСтуденты с образованием = " + education1);
            var students1 = studentCollection.WhereEducation(education1);
            foreach (var student in students1)
                Console.WriteLine("\n" + student.Value.ToShortString());


            var education2 = new Education(EducationLevel.Undergraduate, EducationForm.PartTime, 2, false);
            Console.WriteLine("\nСтуденты с образованием = " + education2);
            var students2 = studentCollection.WhereEducation(education2);
            foreach (var student in students2)
                Console.WriteLine("\n" + student.Value.ToShortString());



            //Группировка элементов списка по значению среднего балла
            Console.WriteLine("\nГруппировка элементов списка по значению среднего балла");
            var groups = studentCollection.AverageMarkGroups;
            foreach (var group in groups)
            {
                Console.WriteLine($"\nГруппа {group.Key}:");

                foreach (var student in group)
                    Console.WriteLine("\n" + student.Value.ToShortString());
            }

            //Группировка элементов списка по образованию
            Console.WriteLine("\nГруппировка элементов списка по образованию");
            var groups2 = studentCollection.EducationGroups;
            foreach (var group in groups2)
            {
                Console.WriteLine($"\nГруппа {group.Key}:");

                foreach (var student in group)
                    Console.WriteLine("\n" + student.Value.ToShortString());
            }
        }
    }
}