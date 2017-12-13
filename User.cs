using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    public class User
    {
        public string Username;
        public string Password;
        public int Role;
        public string Branch;

        public User(string user, string pass, int role, string Branch)
        {
            this.Username = user;
            this.Password = pass;
            this.Role = role;
            this.Branch = Branch;
        }
    }
}
