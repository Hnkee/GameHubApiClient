using GameHubWebSocket;
using Henke.DevUI.MVVMUtils;
using Henke.DevUI.MVVMUtils.Command;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace GameHubApiClient
{
	public class MainViewModel : ViewModelBase, IGameHubExtendedViewObserver
	{
		private Dispatcher _dispatcher;
		private IWebSockectClient _gameHubClient = new GameHubWebSocketClient();
		private float _yawDegrees;
		private float _pitchDegrees;
		private float _rollDegrees;
		private float _xMillimeter;
		private float _yMillimeter;
		private float _zMillimeter;
		private string _info = "no info";
		private string _connectionInfo = "not connected";

		public ICommand StartCommand { get; private set; }
		public string OutputInfo { get; private set; } = "Visualizer";
		public bool Enabled { get; set; }

		public float YawDegrees
		{
			get => _yawDegrees;
			set { _yawDegrees = value; }
		}

		public float PitchDegrees
		{
			get => _pitchDegrees;
			set { _pitchDegrees = value; }
		}

		public float RollDegrees
		{
			get => _rollDegrees;
			set { _rollDegrees = value; }
		}

		public float xMillimeter
		{
			get => _xMillimeter;
			set { _xMillimeter = value; }
		}

		public float yMillimeter
		{
			get => _yMillimeter;
			set { _yMillimeter = value; }
		}

		public float zMillimeter
		{
			get => _zMillimeter;
			set { _zMillimeter = value; }
		}

		public string Info
		{
			get => _info;
			set
			{
				_info = value;
				NotifyPropertyChanged(() => Info);
			}
		}

		public string ConnectionInfo
		{
			get => _connectionInfo;
			set
			{
				_connectionInfo = value;
				NotifyPropertyChanged(() => ConnectionInfo);
			}
		}

		public MainViewModel()
		{
			StartCommand = new DelegateCommand(() => 
			{
				_gameHubClient.Start(this,"demo");
			});
			_dispatcher = Application.Current.Dispatcher;
		}

		public void Write(float yawDegrees, float pitchDegrees, float rollDegrees, float xMillimeter, float yMillimeter, float zMillimeter)
		{
			this.YawDegrees = yawDegrees;
			this.PitchDegrees = pitchDegrees;
			this.RollDegrees = rollDegrees;
			this.xMillimeter = xMillimeter;
			this.yMillimeter = yMillimeter;
			this.zMillimeter = zMillimeter;
		}

		public void OnMessage(GameHubMessage message)
		{

			_dispatcher.Invoke(() =>
			{
				ConnectionInfo = "Connected";
				Info = $"message.yawDegrees: {message.yawDegrees}";
				Write(message.yawDegrees, message.pitchDegrees, message.rollDegrees, message.xMillimeter, message.yMillimeter, message.zMillimeter);
				NotifyPropertyChanged(string.Empty);
			});
		}

		public void OnOpen()
		{
		}

		public void OnClose()
		{
		}
	}
}
