using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningSignalR1
{
    public class MyHub:Microsoft.AspNet.SignalR.Hub
    {
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }
    }
}