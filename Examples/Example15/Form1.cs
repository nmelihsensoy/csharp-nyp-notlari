using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Licence Licence1 = new Licence();
            Licence1.name = textBox1.Text;
            Licence1.Age = int.Parse(textBox2.Text);

            if (Licence1.eligible)
            {
                MessageBox.Show(Licence1.name + " is eligible to drive car." );
            }
            else
            {
                MessageBox.Show(Licence1.name + " is eligible to drive bike.");
            }

        }
    }
}
