using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motherboard.CPU Processor = new Motherboard.CPU();

            label3.Text = Motherboard.Model;
            label4.Text = Processor.Model + " " + Processor.Speed;
            label6.Text = Processor.Core.ToString();

        }
    }
}
