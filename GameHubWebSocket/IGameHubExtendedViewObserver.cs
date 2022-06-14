namespace GameHubWebSocket
{
	public interface IGameHubExtendedViewObserver
	{
		void OnMessage(GameHubMessage message);
		void OnOpen();
		void OnClose();
	}
}