using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DrawCircle(PaintEventArgs e, int x, int y, int width, int height)
        {
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);
        }
        private void DrawRectangle(PaintEventArgs e, int x, int y, int width, int height)
        {
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawRectangle(pen, x - width / 2, y - height / 2, width, height);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = $"X:{e.X} Y:{e.Y} B:{e.Button.ToString()}"
                + $" D:{e.Delta}";

            int x = e.X;
            int y = e.Y;

            Graphics g;
            g = this.panel1.CreateGraphics();

            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                DrawCircle(arg, x, y, 100, 100);
            }
            if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                DrawRectangle(arg, x, y, 100, 100);
            }


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                textBox1.Text += "Left";
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
