using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type a = typeof(string);

            listBox1.Items.Add(a);
            listBox1.Items.Add(typeof(char));
            listBox1.Items.Add(typeof(int));
            listBox1.Items.Add(typeof(int[]));
            listBox1.Items.Add(typeof(bool));
            listBox1.Items.Add(typeof(Array));
            listBox1.Items.Add(typeof(MyClass));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char a = 'a';
            int b = 32;
            int[] c = { 0, 1, 2 };
            bool d = false;

            listBox2.Items.Add(a.GetType());
            listBox2.Items.Add(b.GetType());
            listBox2.Items.Add(c.GetType());
            listBox2.Items.Add(d.GetType());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Type ClassType = typeof(MyClass);
            MethodInfo[] methodList = ClassType.GetMethods();
            foreach (MethodInfo Method in methodList)
            {
                listBox3.Items.Add(Method);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type ClassType = typeof(MyClass);
            MemberInfo[] memberList = ClassType.GetMembers();
            foreach (MemberInfo Member in memberList)
            {
                listBox4.Items.Add(Member);
            }
        }
    }
}
