using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;

namespace SignalR.Controllers.Hubs
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        [HubMethodName("sendMessage")]
        public void letsChat(string Cl_Name, string Cl_Message)
        {
            //Send notification to all clients through NewMessage Method
            Clients.All.NewMessage(Cl_Name, Cl_Message);
        }

        [HubMethodName("getDataForMe")]
        public void ReturnCurrenTime()
        {
            //Send to caller only rather than all client
            Clients.Caller.GetDateTime(DateTime.Now);
        }
    }
}