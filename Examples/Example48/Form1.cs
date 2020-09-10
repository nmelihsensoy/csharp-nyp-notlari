using System;
using System.Windows.Forms;
using FirstSpace;
using SecondSpace.ThirdSpace;

namespace Example48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class3 Class3_Object = new Class3();
            Class3_Object.function3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 Class1_Object = new Class1();
            Class1_Object.function1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 Class2_Object = new Class2();
            Class2_Object.function2();
        }
    }
}
