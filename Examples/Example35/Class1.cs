using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example35
{
    class Class1
    {
        public string cl1 = "";
        public void cl1Message()
        {
            MessageBox.Show(cl1);
        }
    }

    class Class2 : Class1
    {
        public string cl2 = "";
        public void cl2Message()
        {
            MessageBox.Show(cl2);
        }
    }

    class Class3 : Class2
    {
        public string cl3 = "";
        public void cl3Message()
        {
            MessageBox.Show(cl3);
        }
    }
}
