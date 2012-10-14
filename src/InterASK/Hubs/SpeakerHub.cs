using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SignalR;
using SignalR.Hubs;

namespace InterASK.Hubs
{
	[HubName("speaker")]
	public class SpeakerHub : Hub, IDisconnect, IConnected
	{
		public Task Disconnect()
		{
			return Groups.Remove(Context.ConnectionId, "Speakers");
		}

		public Task Connect()
		{
			return Groups.Add(Context.ConnectionId, "Speakers");
		}

		public Task Reconnect(IEnumerable<string> groups)
		{
			return Groups.Add(Context.ConnectionId, "Speakers");
		}
	}
}