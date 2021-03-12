using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H1WebPage
{
    public class UserManager
    {
        DalManager dalManager = new DalManager();
        //public User RegistreUser(User user)
        //{
        //    return dalManager.RegistreUser(user);
        //}

        public User InsertUser(User user, string username, string passw)
        {
            return dalManager.InsertInfo(user, username, passw);
        }

        public string GetValidUsername(string username)
        {
            return dalManager.IsUsernameValid(username);
        }

        public string GetValidPassword(string password)
        {
            return dalManager.IsPasswordValid(password);
        }
    }
}