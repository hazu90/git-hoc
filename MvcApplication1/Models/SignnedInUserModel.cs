using System;
using System.Linq;

namespace MvcApplication1.Models
{
    public class SignnedInUserModel 
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
