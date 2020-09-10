using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation op1 = new Operation();
            op1.setValues(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            op1.sum();
            op1.showResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Operation.helloWorld();
        }

        public void updateView(int a, int b, int c)
        {
            label3.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
        }

        bool error;
        string errorMessage;
        Operation op2 = new Operation();

        private void button2_Click(object sender, EventArgs e)
        {

            op2.setValues(int.Parse(textBox1.Text), int.Parse(textBox2.Text), out error, out errorMessage);

            if (error)
            {
                op2.popOut(errorMessage);
            }
            else
            {
                op2.sum();
                updateView(op2.a, op2.b, op2.result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation.swap(ref op2.a,ref op2.b);
            updateView(op2.a, op2.b, op2.result);
        }
    }
}
