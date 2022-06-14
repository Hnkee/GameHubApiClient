using Newtonsoft.Json;
using WebSocketSharp;

namespace GameHubWebSocket
{
	public class GameHubWebSocketSharpClient : IWebSockectClient
	{
		private WebSocket _websocket;


		public void Start(IGameHubExtendedViewObserver observer, string name)
		{
			_websocket = new WebSocket(GameHub.ConnectionString);
			_websocket.OnOpen += (sender, e) =>
			{
				observer.OnOpen();
			};
			_websocket.OnMessage += (sender, e) =>
			{
				var data = e.Data;
				var message = JsonConvert.DeserializeObject<GameHubMessage>(data);
				observer.OnMessage(message);
			};
			_websocket.OnClose += (sender, e) =>
			{
				observer.OnClose();
			};
			_websocket.Connect();
		}

		public float yawDegrees { get; private set; }
		public float pitchDegrees { get; private set; }
		public float rollDegrees { get; private set; }
		public float xMillimeter { get; private set; }
		public float yMillimeter { get; private set; }
		public float zMillimeter { get; private set; }
	}
}