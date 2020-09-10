using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateLabels();
        }

        Class1 class1 = new Class1("Melih", 21);
        Class1 class2 = new Class1("John", 35);

        string text1 = "Hello";
        string text2 = "World!";
        int number1 = 45;
        int number2 = 26;

        static void swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private void updateLabels()
        {
            label1.Text = text1;
            label2.Text = text2;

            label3.Text = number1.ToString();
            label4.Text = number2.ToString();

            label5.Text = class1.text;
            label6.Text = class2.text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            swap(ref text1, ref text2);
            updateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            swap(ref number1, ref number2);
            updateLabels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            swap(ref class1, ref class2);
            updateLabels();
        }
    }
}
