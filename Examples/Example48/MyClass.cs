using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example48
{
    class Class3
    {
        public void function3()
        {
            MessageBox.Show("Function3 Called");
        }
    }

}

namespace FirstSpace
{
    class Class1
    {
        public void function1()
        {
            MessageBox.Show("Function1 Called");
        }
    }
}

namespace SecondSpace
{
    namespace ThirdSpace
    {
        class Class2
        {
            public void function2()
            {
                MessageBox.Show("Function2 Called");
            }
        }
    }
}
