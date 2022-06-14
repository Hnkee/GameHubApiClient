using Websocket.Client;

namespace GameHubWebSocket
{
	public class GameHubWebSocketClient : IWebSockectClient
	{
		private IGameHubExtendedViewObserver _observer;

		public void Start(IGameHubExtendedViewObserver observer, string name)
		{
			_observer = observer;
			var url = new Uri(GameHub.ConnectionString);
			var client = new WebsocketClient(url);
				client.Name = name;
				client.ReconnectTimeout = TimeSpan.FromSeconds(30);
				client.MessageReceived.Subscribe(MessageReceived);
				client.Start();
		}

		private void MessageReceived(ResponseMessage obj)
		{
			var message = obj.Text.ToGameHubMessage();
			_observer.OnMessage(message);
		}
	}
}