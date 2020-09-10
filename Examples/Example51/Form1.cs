using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                intList.Add(int.Parse(textBox1.Text));
                listBox1.Items.Add(textBox1.Text);
            }
            catch
            {
                label3.Text = "Only integers allowed.";
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                doubleList.Add(double.Parse(textBox2.Text));
                listBox2.Items.Add(textBox2.Text);
            }
            catch
            {
                label3.Text = "Only doubles allowed.";
            }
        }
    }
}
