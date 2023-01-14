using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork6._1
{
    interface Ix
    {
        string F0(int pos); 
        void F1(int pos);
    }

    interface Iy
    {
        void F0(int pos, out string str); 
        void F1(int pos);
    }

    class MyClass : Ix, Iy
    {
        public string String { get; private set; }

        public MyClass(string str) 
        {
            this.String = str; 
        }

        public string F0(int pos)
        {
            string str = this.String.Remove(pos, 1);
            Console.WriteLine("Вызов F0() неявно: str = " + str + str);
            return str + str;
        }

        public void F0(int pos, out string str)
        {
            str = this.String.Remove(pos, 1);
            str += str;
            Console.WriteLine("Вызов F0(out string) неявно: str = " + str);
        }

        public void F1(int pos)
        {
            string str = this.String.Remove(pos, 1);
            this.String = str + str;
            Console.WriteLine("Вызов F1() неявно: String = " + String);
        }

        void Iy.F1(int pos)
        {
            this.String = this.String.Remove(pos, 1).Insert(pos, "+");
            Console.WriteLine("Вызов F1() явно: String = " + String);
        }
    }

    class MyClass2 : Ix, Iy
    {
        public string String { get; private set; }

        public MyClass2(string str)
        {
            this.String = str;
        }

        public string F0(int pos)
        {
            string str = this.String.Substring(pos);
            Console.WriteLine("Вызов F0() неявно: str = " + str);
            return str;
        }

        public void F0(int pos, out string str)
        {
            str = this.String.Substring(pos);
            Console.WriteLine("Вызов F0(out string) неявно: str = " + str);
        }

        public void F1(int pos)
        {
            this.String = this.String.Substring(pos);
            Console.WriteLine("Вызов F1() неявно: String = " + String);
        }

        void Iy.F1(int pos)
        {
            Console.WriteLine("Вызов F1() явно: - ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyClass");
            MyClass myClass = new MyClass("abc");
            myClass.F0(1);
            myClass.F1(1);

            Console.WriteLine("(Ix)MyClass");
            Ix xClass = new MyClass("abc");
            xClass.F0(1);
            xClass.F1(1);

            Console.WriteLine("(Iy)MyClass");
            Iy yClass = new MyClass("abc");
            string str;
            yClass.F0(1, out str);
            yClass.F1(1);

            Console.WriteLine("MyClass2");
            MyClass2 myClass2 = new MyClass2("abc");
            myClass2.F0(1);
            myClass2.F1(1);

            Console.WriteLine("(Ix)MyClass2");
            Ix xClass2 = new MyClass2("abc");
            xClass.F0(1);
            xClass.F1(1);

            Console.WriteLine("(Iy)MyClass2");
            Iy yClass2 = new MyClass2("abc");
            yClass2.F0(1, out str);
            yClass2.F1(1);

            Console.ReadLine();
        }

    }
}
