using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample1
{
    public class User
    {
        public string userId;
        public string userName;

        public User(string userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
        }
    }
}
