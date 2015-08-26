using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
    public class SignalHub : Hub
    {
        public void SendNotification(string notification)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(notification);
        }
    }
}