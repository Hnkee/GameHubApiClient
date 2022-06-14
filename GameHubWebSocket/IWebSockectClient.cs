namespace GameHubWebSocket
{
	public interface IWebSockectClient
	{
		void Start(IGameHubExtendedViewObserver observer, string name);
	}
}