using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2._2
{
    public class Rectangle
    {
        public int x1 { get; private set; }
        public int y1 { get; private set; }

        public int x2 { get; private set; }
        public int y2 { get; private set; }

        public int x3 { get; private set; }
        public int y3 { get; private set; }

        public int x4 { get; private set; }
        public int y4 { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Color Color { get; set; }

        public Rectangle(int x1, int y1, int width, int height) 
        {
            Move(x1, y1);
            Resize(width, height);
        }

        public Rectangle(int x1, int y1, int width, int height, Color color) : this(x1, y1, width, height)
        {
            Color = color;
        }

        public Rectangle(Rectangle rectangle) : this(rectangle.x1, rectangle.y1, rectangle.Width, rectangle.Height, rectangle.Color)
        {
            
        }

        public void Move(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            Resize(Width, Height);
        }

        public void Resize(int width, int height)
        {
            this.x2 = x1 + width;
            this.y2 = y1;

            this.x3 = x1 + width;
            this.y3 = y1 + height;

            this.x4 = x1;
            this.y4 = y1 + height;

            this.Width = width;
            this.Height = height;
        }

        public void Rotate() 
        {
            Resize(Height, Width);
        }

        public Rectangle GetIntersection(Rectangle rectangle)
        {
            int xLeft = Math.Max(this.x1, rectangle.x1);

            int yTop = Math.Max(this.y1, rectangle.y1);

            int xRight = Math.Min(this.x3, rectangle.x3);

            int yBottom = Math.Min(this.y3, rectangle.y3);

            Rectangle intersection = new Rectangle(xLeft, yTop, xRight - xLeft, yBottom - yTop);

            return intersection;
        }

        public Rectangle GetMinUnion(Rectangle movebleRectangle, bool hasIntersection = false, bool isRotateble = false)
        {
            List<Rectangle> unions = new List<Rectangle>();
            List<Rectangle> moveblePositions = new List<Rectangle>();

            movebleRectangle.Move(this.x4, this.y4 + 1);
            Rectangle bottomConnect = GetUnion(movebleRectangle);
            unions.Add(bottomConnect);
            moveblePositions.Add(new Rectangle(movebleRectangle));

            movebleRectangle.Move(this.x2 + 1, this.y2);
            Rectangle rightConnect = GetUnion(movebleRectangle);
            unions.Add(rightConnect);
            moveblePositions.Add(new Rectangle(movebleRectangle));

            if (hasIntersection)
            {
                movebleRectangle.Move(this.x1, this.y1);
                Rectangle intersectionConnect = GetUnion(movebleRectangle);
                unions.Add(intersectionConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));
            }

            if (isRotateble)
            {
                movebleRectangle.Rotate();

                movebleRectangle.Move(this.x4, this.y4 + 1);
                Rectangle rotateBottomConnect = GetUnion(movebleRectangle);
                unions.Add(rotateBottomConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));

                movebleRectangle.Move(this.x2 + 1, this.y2);
                Rectangle rotateRightConnect = GetUnion(movebleRectangle);
                unions.Add(rotateRightConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));

                if (hasIntersection)
                {
                    movebleRectangle.Move(this.x1, this.y1);
                    Rectangle rotateIntersectionConnect = GetUnion(movebleRectangle);
                    unions.Add(rotateIntersectionConnect);
                    moveblePositions.Add(new Rectangle(movebleRectangle));
                }
            }

            Rectangle minUnion = unions[0];
            Rectangle minPosition = moveblePositions[0];

            for (int i = 1; i < unions.Count; i++)
            {
                if (unions[i].Width * unions[i].Height < minUnion.Width * minUnion.Height)
                {
                    minUnion = unions[i];
                    minPosition = moveblePositions[i];
                }
            }

            movebleRectangle.Move(minPosition.x1, minPosition.y1);
            movebleRectangle.Resize(minPosition.Width, minPosition.Height);

            return minUnion;
        }

        public Rectangle GetUnion(Rectangle rectangle)
        {
            int xLeft = Math.Min(this.x1, rectangle.x1);

            int yTop = Math.Min(this.y1, rectangle.y1);

            int xRight = Math.Max(this.x3, rectangle.x3);

            int yBottom = Math.Max(this.y3, rectangle.y3);

            Rectangle union = new Rectangle(xLeft, yTop, xRight - xLeft, yBottom - yTop);

            return union;
        }
    }
}
