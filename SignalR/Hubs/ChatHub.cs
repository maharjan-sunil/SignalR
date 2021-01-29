using Microsoft.AspNet.SignalR;

namespace SignalR.Controllers.Hubs
{
    public class ChatHub : Hub
    {
        public void letsChat(string Cl_Name, string Cl_Message)
        {
            Clients.All.NewMessage(Cl_Name, Cl_Message);
        }
    }
}