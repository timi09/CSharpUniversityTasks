using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(1);
            Rectangle rectangle1 = new Rectangle(1, 2);
            Figure trapezoid1 = new Trapezoid(1, 3, 1);

            List<Figure> figures = new List<Figure>();

            figures.Add(circle1);
            figures.Add(rectangle1);
            figures.Add(trapezoid1);

            foreach (Figure figure in figures)
            {
                figure.Write();
            }

            Console.ReadLine();
        }
    }
}
