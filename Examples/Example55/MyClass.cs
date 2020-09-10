using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example55
{

    interface IHello
    {
        void helloWorld();
    }

    struct MyStruct : IHello
    {
        public void helloWorld()
        {
            MessageBox.Show("Hello World!");
        }
    }
}
