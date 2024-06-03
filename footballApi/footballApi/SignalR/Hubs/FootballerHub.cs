using Api.Controllers;
using Microsoft.AspNetCore.SignalR;

namespace Api.SignalR.Hubs
{
    public class FootballerHub : Hub
    {
        public async Task Send(string firstName, string lastName, string sex,
            string birthday, string country, string teamName)
        {
            await Clients.All.SendAsync("CreateFootballer", firstName, lastName, sex,
            birthday, country, teamName);
        }
    }
}
