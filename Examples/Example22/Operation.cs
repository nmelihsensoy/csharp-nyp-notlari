using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example22
{
    class Operation
    {
        public int a;
        public int b;
        private int _result;
        
        public int result
        {
            get { return _result; }
            set { _result = value; }
        }
        
        static public void helloWorld()
        {
            MessageBox.Show("Hello World!");
        }

        public void resetValues()
        {
            a = 0;
            b = 0;
            result = 0;
        }

        public void sum()
        {
            result = a + b;
        }

        static public void sum(int a, int b, out int result)
        {
            result = a + b;
        }

        static public void multiply(int a, int b, out int result)
        {
            result = a * b;
        }

        public void setValues(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void setValues(int a, int b, out bool error, out string message)
        {
            if ((a < 0) || (b < 0))
            {
                error = true;
                message = "Values cannot be negative";
            }
            else
            {
                this.a = a;
                this.b = b;
                error = false;
                message = " ";
            }
        }

        public void showResult()
        {
            MessageBox.Show("Result: " + result);
        }

        public void popOut(string message)
        {
            MessageBox.Show(message);
        }

        public void popOut(ref string message)
        {
            MessageBox.Show(message);
            message = " ";
        }
        
        public void sqr(ref int i)
        {
            i = i * i;
        }

        public static void swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }

    }
}
