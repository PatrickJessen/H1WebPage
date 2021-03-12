using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H1WebPage
{
    public class User
    {
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }


        public User(string username)
        {
            Username = username;
        }
        public User(string fName, string lName, string password, string hobby)
        {
            FName = fName;
            LName = lName;
            Password = password;
            Hobby = hobby;
        }
    }
}