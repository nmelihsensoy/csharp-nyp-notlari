using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example9_2
{
    public class MyClass
    {
        public MyClass() {
            MessageBox.Show("Constructor Called");
        }

        ~MyClass() {
            MessageBox.Show("Destructor Called");
        }
    }
}
