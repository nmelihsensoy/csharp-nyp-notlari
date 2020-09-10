using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    class Main
    {
        private ArrayList UserList;
        private string firstName;
        private string lastName;

        public Main(ArrayList Users)
        {
            this.UserList = Users;
            this.firstName = Users[0].ToString();
            this.lastName = Users[this.UserList.Count - 1].ToString();
        }

        public string getFirstUser()
        {
            return firstName;
        }

        public string getLastUser()
        {
            return lastName;
        }

    }
}
