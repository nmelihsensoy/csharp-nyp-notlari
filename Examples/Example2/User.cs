using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class User
    {
        public string userName;
        public string userSurname;

        public User()
        {
            this.userName = "John";
            this.userSurname = "Doe";
        }

        public User(string userName, string userSurname) {
            this.userName = userName;
            this.userSurname = userSurname;
        }

    }
}
