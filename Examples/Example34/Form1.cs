using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangle(int edgeVal)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 10);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle((this.ClientRectangle.Width / 2) + 96 - edgeVal/2, (this.ClientRectangle.Height / 2)-edgeVal/2, edgeVal, edgeVal));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void drawCircle(int radius)
        {

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 10);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            radius *= 2;
            Rectangle rect = new Rectangle((this.ClientRectangle.Width / 2) + 96 - radius / 2, (this.ClientRectangle.Height / 2) - radius / 2, radius, radius);

            formGraphics.DrawEllipse(myPen, rect);

            myPen.Dispose();
            formGraphics.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square sq1 = new Square(double.Parse(textBox1.Text));
            drawRectangle(sq1.getEdgeLength());
            label7.Text = sq1.Area().ToString();
            label11.Text = sq1.Perimeter().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle cl1 = new Circle(double.Parse(textBox2.Text));
            drawCircle(cl1.getEdgeLength());
            label8.Text = cl1.Area().ToString();
            label12.Text = cl1.Perimeter().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
