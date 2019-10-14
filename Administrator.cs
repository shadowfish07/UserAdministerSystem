using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAdministerSystem
{
    class Administrator:BaseUser,IUserVaild 
    {
        private string userName;
        private string password;
        public Administrator (string userName, string password)
        {
            Type = UserType.Administrator ;
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
