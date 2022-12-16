using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Safearray safearray;
        private void button1_Click(object sender, EventArgs e)
        {
            safearray = new Safearray();
            UpdateSafearrayTextBox();
        }

        private void UpdateSafearrayTextBox() 
        {
            richTextBox1.Clear();
            richTextBox2.Clear();

            for (int i = 0; i < safearray.getLimit(); i++)
            {
                richTextBox1.AppendText(safearray[i] + "\t", Color.Blue);
                richTextBox2.Text += i + "\t";
            }
        }

        Safehilo safehilo;
        private void button2_Click(object sender, EventArgs e)
        {
            int start = (int)numericUpDown1.Value;
            int end = (int)numericUpDown2.Value;

            safehilo = new Safehilo(start, end);
            UpdateSafehiloTextBox();
        }

        private void UpdateSafehiloTextBox() 
        {
            richTextBox4.Clear();
            richTextBox3.Clear();

            for (int i = 0; i < safehilo.getLimit(); i++)
            {
                if (i < safehilo.Start || i > safehilo.End) 
                    richTextBox4.AppendText(0 + "\t", Color.Red);
                else
                    richTextBox4.AppendText(safehilo[i] + "\t", Color.Blue);
                richTextBox3.Text += i + "\t";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (safehilo == null)
                return;

            int value = (int)numericUpDown8.Value;
            int index = (int)numericUpDown7.Value;
            safehilo[index] = value;
            UpdateSafehiloTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (safearray == null)
                return;

            int value = (int)numericUpDown3.Value;
            int index = (int)numericUpDown4.Value;
            safearray[index] = value;
            UpdateSafearrayTextBox();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
