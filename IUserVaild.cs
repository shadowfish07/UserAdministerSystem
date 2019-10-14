using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAdministerSystem
{
    interface IUserVaild
    {
        public Boolean LoginCheck(string UserName, string Password);
    }
}
