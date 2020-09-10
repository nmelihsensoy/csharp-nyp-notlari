using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example39
{
    class Example39
    {
        StringOps str = new StringOps();
        public string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        stringHandler strRev;
        stringHandler rToComma;
        stringHandler rToSpace;
        stringHandler removeSpaces;
        stringHandler chainOp;

        public Example39()
        {
            strRev = str.reverseString;
            rToComma = str.replaceToComma;
            rToSpace = str.replaceToSpace;
            removeSpaces = str.removeSpaces;
            chainOp = str.getStr;
        }

        public string loremReverse(string text)
        {
            stringHandler strHandler = str.reverseString;
            strHandler(ref text);

            return text;
        }

        public string loremReplace(string text)
        {
            stringHandler strHandler = str.replaceToComma;
            strHandler(ref text);

            return text;
        }

        public string chainedOp(string text)
        {
            stringHandler op1 = new stringHandler(str.replaceToComma);
            stringHandler op2 = new stringHandler(str.reverseString);
            stringHandler op3 = op1;

            op3 += op2;
            op3(ref text);

            return text;
        }

        /*
         0 - Reverse
         1 - Replace Spaces With Commas
         2 - Remove Spaces
         3 - Replace Commas With Spaces
         */
        public void addToChain(short opt)
        {
            if (opt == 0)
            {
                chainOp += strRev;
            }
            else if (opt == 1)
            {
                chainOp += rToComma;
            }
            else if (opt == 2)
            {
                chainOp += removeSpaces;
            }
            else if (opt == 3)
            {
                chainOp += rToSpace;
            }
        }

        /*
         0 - Reverse
         1 - Replace Spaces With Commas
         2 - Remove Spaces
         3 - Replace Commas With Spaces
         */
        public void removeToChain(short opt)
        {
            if (opt == 0)
            {
                chainOp -= strRev;
            }
            else if (opt == 1)
            {
                chainOp -= rToComma;
            }
            else if (opt == 2)
            {
                chainOp -= removeSpaces;
            }
            else if (opt == 3)
            {
                chainOp -= rToSpace;
            }
        }

        public string applyChain(string text)
        {
            chainOp(ref text);
            chainOp = str.getStr;
            return text;
        }

    }
}
