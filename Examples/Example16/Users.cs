using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example16
{
    class Users
    {
        private string[] names;
        private int size;

        public Users(int size)
        {
            this.size = size;
            names = new string[size];
            for (int i = 0; i < size; i++)
                names[i] = "NA";
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = names[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    names[index] = value;
                }
            }

        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < this.size)
                {
                    if (names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }

    }
}
