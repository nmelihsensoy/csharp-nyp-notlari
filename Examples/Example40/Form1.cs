using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example40
{
    public partial class Form1 : Form
    {
        EventMethods eM = new EventMethods();

        public Form1()
        {
            InitializeComponent();
            this.Click += formAlert;
        }

        private void formAlert(object obj, EventArgs e)
        {
            MessageBox.Show("You Clicked Canvas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventMethods eM = new EventMethods();
            button2.Click += eM.clickButton;
        }
    }
}
