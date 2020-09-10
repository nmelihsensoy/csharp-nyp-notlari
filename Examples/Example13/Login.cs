
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13
{
    class Login
    {
        private string fullName;
        
        public string formalName
        {
            get
            {
                return string.Format("Welcome dear {0}", this.fullName);
            }
        }

        public void setName(string name)
        {
            this.fullName = name;
        }

    }
}
