using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        Users UsersClass = new Users(6);
        
        private void Add_Click(object sender, EventArgs e)
        {
            if (counter < 6)
            {

                UsersClass[counter] = textBox1.Text;
                counter++;
                updateListBox();
            }
            else
            {
                MessageBox.Show("User Limit Exceeded");
            }
        }
        
        private void updateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                listBox1.Items.Add(UsersClass[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (UsersClass[name] == -1)
            {
                label1.Text = "Didn't Found";
            }
            else
            {
                int foundIndex = UsersClass[name];
                label1.Text = (foundIndex + 1).ToString() + ". " + UsersClass[UsersClass[name]];
            }
        }
    }
}
