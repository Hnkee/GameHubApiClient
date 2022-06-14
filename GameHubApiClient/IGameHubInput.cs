using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHubApiClient
{
	public interface IGameHubInput
	{
		string InputInfo { get; }

		bool Enabled { get; set; }

		void Write(float yawDegrees, float pitchDegrees, float rollDegrees, float xMillimeter, float yMillimeter, float zMillimeter);
	}

	public class GameHubGrpcInput
	{

	}

	public class GameHubWebSocketInput : IGameHubInput
	{
		private bool _enabled;

		public string InputInfo => "Websocket input";

		public bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; }
		}

		public void Write(float yawDegrees, float pitchDegrees, float rollDegrees, float xMillimeter, float yMillimeter, float zMillimeter)
		{
			throw new NotImplementedException();
		}
	}
}
