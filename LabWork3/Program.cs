using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v3
{
    class Program
    {
        public static Time Tm1;
        public static Time Tm2;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время");

            Console.Write("Введите часы: ");
            string h = Console.ReadLine();
            Console.Write("Введите минуты: ");
            string m = Console.ReadLine();
            Console.Write("Введите секунды: ");
            string s = Console.ReadLine();
            Tm1 = new Time(int.Parse(h), int.Parse(m), int.Parse(s));
            Console.WriteLine(Tm1.ToString());

            Console.WriteLine("Введите вычитаемое время");

            Console.Write("Введите часы: ");
            h = Console.ReadLine();
            Console.Write("Введите минуты: ");
            m = Console.ReadLine();
            Console.Write("Введите секунды: ");
            s = Console.ReadLine();
            Tm2 = new Time(int.Parse(h), int.Parse(m), int.Parse(s));
            Console.WriteLine(Tm2.ToString());

            Console.WriteLine($"Разность времени: {Tm1 - Tm2}");

            Console.WriteLine("Введите время для умножения");

            Console.Write("Введите часы: ");
            h = Console.ReadLine();
            Console.Write("Введите минуты: ");
            m = Console.ReadLine();
            Console.Write("Введите секунды: ");
            s = Console.ReadLine();
            Tm2 = new Time(int.Parse(h), int.Parse(m), int.Parse(s));
            Console.WriteLine(Tm2.ToString());

            Console.Write("Введите коэффициент: ");
            double k = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Умноженное время: {k * Tm2}");

            Console.ReadKey();
        }
    }
}
