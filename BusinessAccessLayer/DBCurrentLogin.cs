using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace BusinessAccessLayer
{
    public class DBCurrentLogin
    {
        private static DBCurrentLogin LoginInfo = null;
        public static DBCurrentLogin GetCurrentLoginInfo()
        {
            if (LoginInfo == null)
            {
                LoginInfo = new DBCurrentLogin();
            }
            return LoginInfo;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string MaNV { get; set; }
    }
}
