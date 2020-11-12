
namespace Common
{
    public static class WhoIsUserLog
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
