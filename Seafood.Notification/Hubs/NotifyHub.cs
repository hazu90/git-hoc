using Microsoft.AspNet.SignalR;
using Seafood.Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seafood.Notification.Hubs
{
    public class NotifyHub:Hub
    {
        public override System.Threading.Tasks.Task OnConnected()
        {
            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public List<NotificationModel> Send()
        {
            return new List<NotificationModel>();
        }
    }
}