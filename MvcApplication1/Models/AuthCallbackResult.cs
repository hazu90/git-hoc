using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AuthCallbackResult
    {
        public string ErrorText { get; set; }

        public string RedirectUrl { get; set; }
    }
}