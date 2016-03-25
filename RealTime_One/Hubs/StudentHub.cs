using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RealTime_One.Hubs
{
    public class StudentHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}