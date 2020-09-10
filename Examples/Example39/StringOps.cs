using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example39
{

    delegate void stringHandler(ref string str);
    class StringOps
    {

        public void getStr(ref string str)
        {
           
        }

        public void replaceToComma(ref string str)
        {
            str = str.Replace(" ", ",");
        }

        public void replaceToSpace(ref string str)
        {
            str = str.Replace(", ", " ");
        }

        public void removeSpaces(ref string str)
        {
            str = str.Replace(" ", "");
        }

        public void reverseString(ref string str)
        {
            string temp = "";
            for (int i= str.Length-1; i >= 0; i--)
            {
                temp += str[i];
            }

            str = temp;
        }

    }
}
