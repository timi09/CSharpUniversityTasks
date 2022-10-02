using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create 1");
            {
                {
                    Exam exam = new Exam();
                }

                {
                    Exam exam = new Exam("Петя", "21.09.2022", 4);
                    Exam exam1 = new Exam(exam);
                }
            }

            Console.WriteLine("GC.Collect 1");

            GC.Collect();

            Console.ReadLine();

            //2
            Console.WriteLine("Create 2");
            CreateExam();
            CreateExamParameters();
            CreateExamCopy();

            Console.WriteLine("GC.Collect 2");

            GC.Collect();

            Console.ReadLine();


            //3
            Console.WriteLine("Create 3");
            Exam[] exams = new Exam[3] { new Exam(), new Exam("Костя", "22.09.2022", 5), new Exam(new Exam()) };

            Console.WriteLine("GC.Collect 3");
            
            GC.Collect();

            Console.ReadLine();

            //4
            Console.WriteLine("Create 4");
            Exam exam2 = new Exam(new Exam());

            Console.WriteLine("GC.Collect 4");

            GC.Collect();

            Console.ReadLine();
        }

        private static void CreateExam()
        {
            Exam exam = new Exam();
        }

        private static void CreateExamParameters() 
        {
            Exam exam = new Exam("Петя", "21.09.2022", 4);
        }

        private static void CreateExamCopy()
        {
            Exam exam = new Exam("Саша", "21.09.2022", 5);
            Exam exam2 = new Exam(exam);
        }

        public class Exam 
        {
            public string StudentName;
            public string Date;
            public int Grade;

            public Exam()
            {
                StudentName = "Вася";
                Date = "20.09.2022";
                Grade = 5;
                Console.WriteLine($"Конструктор без параметров. Объект: {this}");
            }

            public Exam(string studentName, string date, int grade)
            {
                StudentName = studentName;
                Date = date;
                Grade = grade;
                Console.WriteLine($"Конструктор с параметрами. Объект: {this}");
            }

            public Exam(Exam exam)
            {
                StudentName = exam.StudentName;
                Date = exam.Date;
                Grade = exam.Grade;
                Console.WriteLine($"Конструктор копирования. Объект: {this}");
            }

            public override string ToString() 
            {
                return $"Студент: {StudentName}, дата: {Date}, оценка: {Grade}";
            }

            ~Exam()
            {
                Console.WriteLine($"Объект: {this} разрушен");
            }
        }   
    }
}
