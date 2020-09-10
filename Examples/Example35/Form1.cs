using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class3 cl3 = new Class3();
            ((Class1)cl3).cl1 = "Class1 Method Executed";
            ((Class1)cl3).cl1Message();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 cl2 = new Class2();
            ((Class1)cl2).cl1 = "Class1 Method Executed";
            ((Class1)cl2).cl1Message();
        }
    }
}
