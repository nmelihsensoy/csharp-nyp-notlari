using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users(textBox1.Text, textBox2.Text, textBox3.Text);
            SerializeWrapper.fileName = "Users.dat";
            SerializeWrapper.binarySerialize(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users user = SerializeWrapper.binaryDeserialize();
            label7.Text = user.userName;
            label8.Text = user.email;
            label9.Text = user.country;
        }
    }
}
