using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = new User(textBox1.Text, (textBox2.Text));
            label5.Text = newUser.userName;
            label6.Text = newUser.userSurname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            label5.Text = newUser.userName;
            label6.Text = newUser.userSurname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
