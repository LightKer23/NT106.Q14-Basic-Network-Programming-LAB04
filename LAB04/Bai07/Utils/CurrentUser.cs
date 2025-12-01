using Bai07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07.Utils
{
    public class CurrentUser
    {
        public static UserInfo? User { get; private set; }
        public static bool IsLoggedIn => User != null;
        public static void SetUser(UserInfo user)
        {
            User = user;
        }
        public static void ClearUser()
        {
            User = null;
        }
    }
}
