using Microsoft.AspNetCore.SignalR;
using RandomizerAPI.Models.GameModels;
using RandomizerAPI.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.HubConfig
{
    public class SpoilerLogSessionHub: Hub
    {
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

            //await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
        }

        public async Task Send(OoTSpoilerLog log, string ID)
        {
            var resp = new SaveSessionResponse()
            {
                ID = ID,
                SpoilerLog = log
            };

            await Clients.Others.SendAsync("sendSpoilerData", resp);
        }
    }
}
