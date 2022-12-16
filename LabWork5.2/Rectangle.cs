using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._2
{
    class Rectangle : Figure
    {
        public double Width;
        public double Height;
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double getArea()
        {
            return Width * Height;
        }

        public override double getPerimeter()
        {
            return 2*(Width + Height);
        }

        public override void Write()
        {
            Console.WriteLine($"Прямоугольник ширина = {Width}, " +
                $"высота = {Height}, " +
                $"периметр = {getPerimeter()}, " +
                $"площадь = {getArea()}");
        }
    }
}
