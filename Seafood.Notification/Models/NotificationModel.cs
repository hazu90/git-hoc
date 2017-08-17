using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seafood.Notification.Models
{
    public class NotificationModel
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
    }
}