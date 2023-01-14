using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly List<Color> colors = new List<Color>() 
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Black
        };

        private readonly List<Rectangle> rectangles = new List<Rectangle>();

        public void Update()
        {
            Graphics graphics = this.pictureBox1.CreateGraphics();

            graphics.Clear(pictureBox1.BackColor);

            foreach (var rectangle in rectangles)
            {
                graphics.DrawLine(new Pen(rectangle.Color), rectangle.x1, rectangle.y1, rectangle.x2, rectangle.y2);

                graphics.DrawLine(new Pen(rectangle.Color), rectangle.x2, rectangle.y2, rectangle.x3, rectangle.y3);

                graphics.DrawLine(new Pen(rectangle.Color), rectangle.x3, rectangle.y3, rectangle.x4, rectangle.y4);

                graphics.DrawLine(new Pen(rectangle.Color), rectangle.x4, rectangle.y4, rectangle.x1, rectangle.y1);
            }
        }

        public void RedrawByUserData(int rectIndx)
        {
            if (rectIndx > rectangles.Count - 1)
                return;

            if (rectIndx < 0)
                rectIndx = 0;
                
               

            int x = (int)x1Numeric.Value;
            int y = (int)y1Numeric.Value;

            int width = (int)widthNumeric.Value;
            int height = (int)heightNumeric.Value;

            rectangles[rectIndx].Move(x, y);
            rectangles[rectIndx].Resize(width, height);

            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorsListBox.SelectedIndex == -1)
                colorsListBox.SelectedIndex = 0;
            Color color = colors[colorsListBox.SelectedIndex];

            rectanglesListBox.Items.Add("Rectangle " + (rectangles.Count + 1));

            rectangles.Add(new Rectangle(50, 50 , 80, 40, color));
            Update();
        }

        private void x1Numeric_ValueChanged(object sender, EventArgs e)
        {
            int rectIndx = rectanglesListBox.SelectedIndex;
            RedrawByUserData(rectIndx);
        }
        private void y1Numeric_ValueChanged(object sender, EventArgs e)
        {
            int rectIndx = rectanglesListBox.SelectedIndex;
            RedrawByUserData(rectIndx);
        }

        private void widthNumeric_ValueChanged(object sender, EventArgs e)
        {
            int rectIndx = rectanglesListBox.SelectedIndex;
            RedrawByUserData(rectIndx);
        }

        private void heightNumeric_ValueChanged(object sender, EventArgs e)
        {
            int rectIndx = rectanglesListBox.SelectedIndex;
            RedrawByUserData(rectIndx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle ints = rectangles[0].GetIntersection(rectangles[1]);

            ints.Color = Color.Purple;

            rectanglesListBox.Items.Add("Intersection " + (rectangles.Count + 1));

            rectangles.Add(ints);
            Update();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumerics();
        }

        private void UpdateNumerics() 
        {
            int rectIndx = rectanglesListBox.SelectedIndex;

            if (rectIndx == -1)
                return;

            x1Numeric.ValueChanged -= x1Numeric_ValueChanged;
            y1Numeric.ValueChanged -= y1Numeric_ValueChanged;
            widthNumeric.ValueChanged -= widthNumeric_ValueChanged;
            heightNumeric.ValueChanged -= heightNumeric_ValueChanged;

            x1Numeric.Value = rectangles[rectIndx].x1;
            y1Numeric.Value = rectangles[rectIndx].y1;

            widthNumeric.Value = rectangles[rectIndx].Width;
            heightNumeric.Value = rectangles[rectIndx].Height;

            x1Numeric.ValueChanged += x1Numeric_ValueChanged;
            y1Numeric.ValueChanged += y1Numeric_ValueChanged;
            widthNumeric.ValueChanged += widthNumeric_ValueChanged;
            heightNumeric.ValueChanged += heightNumeric_ValueChanged;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool hasIntersection = hasIntersectionCheckBox.Checked;
            bool isRotateble = isRotatebleCheckBox.Checked;

            Rectangle union = rectangles[0].GetMinUnion(rectangles[1], hasIntersection, isRotateble);

            union.Color = Color.Magenta;

            rectanglesListBox.Items.Add("Min Union " + (rectangles.Count + 1));

            rectangles.Add(union);
            Update();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int rectIndx = rectanglesListBox.SelectedIndex;
            if (rectIndx != -1)
            {
                rectangles[rectIndx].Rotate();
                Update();
                UpdateNumerics();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool hasIntersection = hasIntersectionCheckBox.Checked;
            bool isRotateble = isRotatebleCheckBox.Checked;

            Rectangle rect = rectangles[0];
            Rectangle movebleRectangle = rectangles[1];

            List<Rectangle> unions = new List<Rectangle>();
            List<Rectangle> moveblePositions = new List<Rectangle>();

            movebleRectangle.Move(rect.x4, rect.y4 + 1);
            Rectangle bottomConnect = rect.GetUnion(movebleRectangle);
            unions.Add(bottomConnect);
            moveblePositions.Add(new Rectangle(movebleRectangle));

            movebleRectangle.Move(rect.x2 + 1, rect.y2);
            Rectangle rightConnect = rect.GetUnion(movebleRectangle);
            unions.Add(rightConnect);
            moveblePositions.Add(new Rectangle(movebleRectangle));

            if (hasIntersection)
            {
                movebleRectangle.Move(rect.x1, rect.y1);
                Rectangle intersectionConnect = rect.GetUnion(movebleRectangle);
                unions.Add(intersectionConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));
            }

            if (isRotateble)
            {
                movebleRectangle.Rotate();

                movebleRectangle.Move(rect.x4, rect.y4 + 1);
                Rectangle rotateBottomConnect = rect.GetUnion(movebleRectangle);
                unions.Add(rotateBottomConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));

                movebleRectangle.Move(rect.x2 + 1, rect.y2);
                Rectangle rotateRightConnect = rect.GetUnion(movebleRectangle);
                unions.Add(rotateRightConnect);
                moveblePositions.Add(new Rectangle(movebleRectangle));

                if (hasIntersection)
                {
                    movebleRectangle.Move(rect.x1, rect.y1);
                    Rectangle rotateIntersectionConnect = rect.GetUnion(movebleRectangle);
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

            foreach (var union in unions)
            {
                union.Color = Color.Cyan;

                rectanglesListBox.Items.Add("Union " + (rectangles.Count + 1));

                rectangles.Add(union);
            }

            movebleRectangle.Move(minPosition.x1, minPosition.x2);
            movebleRectangle.Resize(minPosition.Width, minPosition.Height);

            minUnion.Color = Color.Magenta;

            Update();
        }
    }

    
}
