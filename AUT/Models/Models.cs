using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AUT.Models
{
    public class LoginModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
    }
}