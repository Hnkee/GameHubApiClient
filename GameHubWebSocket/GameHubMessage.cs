using Newtonsoft.Json;

namespace GameHubWebSocket
{
	public class GameHubMessage
	{
		public float yawDegrees;
		public float pitchDegrees;
		public float rollDegrees;
		public float xMillimeter;
		public float yMillimeter;
		public float zMillimeter;
	}

	public static class GameHubMessageExtensions
	{
		public static GameHubMessage ToGameHubMessage(this string text)
		{
			var message = JsonConvert.DeserializeObject<GameHubMessage>(text);
			return message;
		}
	}
	
}