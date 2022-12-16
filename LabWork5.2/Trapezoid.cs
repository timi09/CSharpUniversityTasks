using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5._2
{
    class Trapezoid : Figure
    {
        public double TopWidth;
        public double BottomWidth;
        public double Height;

        public Trapezoid(double topWidth, double bottomWidth, double height)
        {
            TopWidth = topWidth;
            BottomWidth = bottomWidth;
            Height = height;
        }

        public override double getArea()
        {
            return TopWidth*Height + (BottomWidth-TopWidth)/2 * Height;
        }

        public override double getPerimeter()
        {
            double a = (BottomWidth - TopWidth) / 2;
            double side3 = getHypotenuse(a, Height);

            return TopWidth + BottomWidth + 2 * side3;
        }

        private double getHypotenuse(double a, double b) 
        {
            return Math.Sqrt(a*a + b*b);
        }

        public override void Write()
        {
            Console.WriteLine($"Равнобедренная трапеция ширина верха = {TopWidth}, " +
                $"ширина низа = {BottomWidth}, " +
                $"высота = {Height}, " +
                $"боковая сторона = {getHypotenuse((BottomWidth - TopWidth) / 2, Height)}, " +
                $"периметр = {getPerimeter()}, площадь = {getArea()}");
        }
    }
}
