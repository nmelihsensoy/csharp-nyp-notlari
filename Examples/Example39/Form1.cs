using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example39
{
    public partial class Form1 : Form
    {
        Example39 app = new Example39();

        public Form1()
        {
            InitializeComponent();
            label1.Text = app.lorem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = app.loremReverse(label1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = app.chainedOp(label1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            app.addToChain(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = app.applyChain(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            app.addToChain(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            app.addToChain(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            app.addToChain(3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = app.loremReplace(label1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            app.removeToChain(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            app.removeToChain(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            app.removeToChain(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            app.removeToChain(3);
        }
    }
}
