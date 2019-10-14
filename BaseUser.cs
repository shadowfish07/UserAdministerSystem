using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAdministerSystem
{
    enum UserType
    {
        Guest,
        User,
        Administrator
    }
    class BaseUser
    {
        protected string ID ;
        public UserType Type;
        static public  int OrderNum = 0;

        protected  string OrderNumFormat()
        {
            if (OrderNum <= 9)
                return "00" + OrderNum.ToString();
            else if (OrderNum <= 99)
                return "0" + OrderNum.ToString();
            else
                return OrderNum.ToString();
        }

        protected  BaseUser()
        {
            OrderNum++;
            GenerateID();
        }

        public string GetID()
        {
            return ID;
        }

        private   void GenerateID()
        {
            ID = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + OrderNumFormat();
        }

    }
}
