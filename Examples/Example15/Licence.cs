using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example15
{
    class Licence
    {
        public string name { get; set; }
        public bool eligible = true;
        private int _age;
        
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    this.eligible = false;   
                }
                this._age = value;
            }
        }


    }
}
