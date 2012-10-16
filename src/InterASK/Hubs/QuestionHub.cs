using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SignalR.Hubs;

namespace InterASK.Hubs
{
	//[HubName("question")]
	public class Question : Hub, IDisconnect, IConnected
	{

		public void AskQuestion(string question)
		{
			Clients.addUnverifiedQuestion(question, Context.ConnectionId);				// works
			Clients["Speaker"].addUnverifiedQuestion(question, Context.ConnectionId);	// doesn't work
			Clients["Question"].thanks();												// nor does this
		}

		public Task JoinGroup()
		{
			return Groups.Add(Context.ConnectionId, "Questions");
		}
		public Task Disconnect()
		{
			return Groups.Remove(Context.ConnectionId, "Questions");
		}

		public Task Connect()
		{
			return Groups.Add(Context.ConnectionId, "Questions");
		}

		public Task Reconnect(IEnumerable<string> groups)
		{
			return Groups.Add(Context.ConnectionId, "Questions");
		}
	}
}