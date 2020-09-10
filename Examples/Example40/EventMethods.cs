using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example40
{
    class EventMethods
    {
        public void clickButton(object obj, EventArgs e)
        {
            MessageBox.Show("You Clicked Button");
        }
    }
}
