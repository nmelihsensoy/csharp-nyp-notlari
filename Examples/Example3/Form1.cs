using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {

        ArrayList Users = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text + " " + textBox2.Text;
            Users.Add(fullName);
            listBox1.Items.Add(fullName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainClass = new Main(this.Users);
            label5.Text = MainClass.getFirstUser();
            label6.Text = MainClass.getLastUser();
        }
    }
}
