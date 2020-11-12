<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class IsUserLog
=======
﻿
namespace Common
{
    public static class WhoIsUserLog
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
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
