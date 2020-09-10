using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Operation.Utility.absVal(int.Parse(textBox1.Text));
            int b = Operation.Utility.absVal(int.Parse(textBox2.Text));
            int result = Operation.sum(a, b);
            label4.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Operation.Utility.absVal(int.Parse(textBox1.Text));
            int b = Operation.Utility.absVal(int.Parse(textBox2.Text));
            int result = Operation.multiply(a, b);
            label4.Text = result.ToString();
        }
    }
}
