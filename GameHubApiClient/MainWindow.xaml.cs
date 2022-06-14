using System.Windows;

namespace GameHubApiClient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window 
	{ 
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}

	}
}
