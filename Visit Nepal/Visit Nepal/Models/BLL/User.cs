using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visit_Nepal.Models.BLL
{
    public class User
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string PassKey { get; set; }
        public bool status { get; set; }
        public string RoleID { get; set; }
        public string Email { get; set; }
    }
}