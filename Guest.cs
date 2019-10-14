using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAdministerSystem
{
    class Guest : BaseUser
    {
        public Guest()
        {
            Type = UserType.Guest;
        }
    }
}
