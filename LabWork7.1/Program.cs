using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabWork7._1
{
    public delegate string MyDelegate(int pos, string str);

    class MyClass1 
    {
        static public string Double(int pos, string str) 
        {
            str = str.Remove(pos, 1);
            Console.WriteLine("Вызов MyClass1.Double() : str = " + str + str);
            return str + str;
        }

        public string Replace(int pos, string str)
        {
            str = str.Remove(pos, 1).Insert(pos, "+");
            Console.WriteLine("Вызов MyClass1.Replace() : str = " + str);
            return str;
        }
    }

    class MyClass2
    {
        public string Substring(int pos, string str)
        {
            str = str.Substring(pos);
            Console.WriteLine("Вызов MyClass2.Substring() : str = " + str);
            return str;
        }
    }
    class ClassWithEvent 
    {
        public event MyDelegate OnEvent;
        public void Trigger(int pos, string str) 
        {
            OnEvent(pos, str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. делегаты");
            
            Console.WriteLine("Вызов разных методов одним делегатом");
            MyDelegate myDelegate = MyClass1.Double;
            myDelegate.Invoke(1, "abc");

            MyClass1 class1 = new MyClass1();
            myDelegate = class1.Replace;
            myDelegate.Invoke(1, "abc");

            MyClass2 class2 = new MyClass2();
            myDelegate = class2.Substring;
            myDelegate.Invoke(2, "abccsb");

            myDelegate = null;

            Console.WriteLine("Вызов цепочки методов одним делегатом");
            myDelegate += MyClass1.Double;
            myDelegate += class1.Replace;
            myDelegate += class2.Substring;

            myDelegate.Invoke(2, "abccsb");

            Console.WriteLine("Задача 2. события");
            ClassWithEvent eventClass = new ClassWithEvent();

            eventClass.OnEvent += MyClass1.Double;
            eventClass.OnEvent += class1.Replace;
            eventClass.OnEvent += class2.Substring;

            Console.WriteLine("Вызов события");
            eventClass.Trigger(1, "Да");

            Console.ReadLine();
        }
    }
}
