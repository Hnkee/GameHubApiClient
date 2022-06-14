namespace GameHubWebSocket
{

	public static class GameHub
	{
		public const string Connection= "ws://127.0.0.1";
		public const string Route= "/GameHub";
		public const int Port = 7887;
		public static string ConnectionString => $"{Connection}:{Port}{Route}";
	}
	
}