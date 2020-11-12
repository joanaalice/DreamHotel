using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class IsUserLog
    {
        public static UserLoged CurrentUser { get; set; }
        public static bool IsUserLoged()
        {
            return CurrentUser != null;
        }
        public static void UserLogout()
        {
            CurrentUser = null;
        }
    }
}
