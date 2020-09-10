using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Edge aEdge = new Edge(0, 0, 0, 0);
 
        private void button1_Click(object sender, EventArgs e)
        {
            aEdge.a.x = int.Parse(textBox1.Text);
            aEdge.a.y = int.Parse(textBox2.Text);
            aEdge.b.x = int.Parse(textBox3.Text);
            aEdge.b.y = int.Parse(textBox4.Text);
            aEdge.update();

            label6.Text = aEdge.length.ToString();

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 2);

            PointF point1 = new PointF((float)(aEdge.a.x + 200), (float)aEdge.a.y);
            PointF point2 = new PointF((float)(aEdge.b.x + 200), (float)aEdge.b.y);

            e.Graphics.DrawLine(blackPen, point1, point2);
        }

    }
}
