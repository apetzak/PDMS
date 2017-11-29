using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    class User
    {
        public string Username;
        public string Password;
        public int Role;

        public User(string user, string pass, int role)
        {
            this.Username = user;
            this.Password = pass;
            this.Role = role;
        }
    }
}
