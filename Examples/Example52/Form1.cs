using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intListCounter = 0;
        int doubleListCounter = 0;
        GenericArray<int> intList = new GenericArray<int>(5, -1);
        GenericArray<double> doubleList = new GenericArray<double>(5, -0.1);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                intList[intListCounter] = int.Parse(textBox1.Text);
                intListCounter++;
                listBox1.Items.Clear();
                for (int i=0; i<5; i++)
                {
                    listBox1.Items.Add(intList[i]);
                }
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
                doubleList[doubleListCounter] = double.Parse(textBox2.Text);
                doubleListCounter++;
                listBox2.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    listBox2.Items.Add(doubleList[i]);
                }
            }
            catch
            {
                label3.Text = "Only doubles allowed.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intList.swapFirstSecond();
            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(intList[i]);
            }
        }
    }
}
