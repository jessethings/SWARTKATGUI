using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortunaUploader.Scripts
{
    public static class Login
    {
        public static int AttemptLogin(string username, string password, bool skip = false)
        {
            if (skip)
                return 0;

            System.Net.WebClient wc = new System.Net.WebClient();
            string[] webData = wc.DownloadString("http://pastebin.com/raw/KFkAtxtu").Split();
            if (username == webData[0])
                if (password == webData[2])
                    return 1;

            return 0;
        }

        public static string GetFarmName(int farmID)
        {
            return "Kounga";
        }

        public static AccessLevel GetAccessLevel(int farmID, AccessLevel skip = AccessLevel.Guest)
        {
            if (skip != AccessLevel.Guest)
                return skip;

            return AccessLevel.User;
        }
    }
}
