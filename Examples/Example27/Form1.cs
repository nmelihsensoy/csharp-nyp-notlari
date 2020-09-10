using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example27
{
    public partial class Form1 : Form
    {

        Person person1;
        public Form1()
        {
            InitializeComponent();
            person1 = new Person("John Doe", "M.I.T");
            person1.setLocation("Massachusetts");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person1.showAllData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            label1.Text = person1.getAllData();
        }
    }
}
