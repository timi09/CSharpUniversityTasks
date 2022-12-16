using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._2
{
    class Circle : Figure
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Radius * Radius; 
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Write()
        {
            Console.WriteLine($"Круг радиус = {Radius}, " +
                $"периметр = {getPerimeter()}, " +
                $"площадь = {getArea()}");
        }
    }
}
