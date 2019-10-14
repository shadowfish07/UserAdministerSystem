using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAdministerSystem
{
    class User:BaseUser,IUserVaild 
    {
        private string userName;
        private string password;
        public User(string userName,string password)
        {
            Type = UserType.User;
        }

        public Boolean LoginCheck(string userName, string password)
        {
            if (this.password == password && this.userName == userName)
                return true;
            else
                return false;
        }
    }
}
