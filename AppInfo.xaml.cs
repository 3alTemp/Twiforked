using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Twiforked
{
	/// <summary>
	/// Interaction logic for AppInfo.xaml
	/// </summary>
	public partial class AppInfo : Window
	{
		public AppInfo(){InitializeComponent();}

		private void Border_MouseDown(object sender, MouseButtonEventArgs e)
		{   // Drag the window when hold-clicking the top border
			if (Mouse.LeftButton == MouseButtonState.Pressed)
				DragMove();
		}

		// Closes the window
		private void Close_Click(object sender, RoutedEventArgs e) { Close(); }

		// Handlers
		private void OpenWebsite(string url){ Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true }); }
		private void ChangeButtonIcon(object button, string dir){  }

		// Links
		private void YT_Click(object sender, RoutedEventArgs e) { OpenWebsite("https://www.youtube.com/channel/UCsyDTX7NIc7VNo60MPIwkSg/"); }
		private void Git_Click(object sender, RoutedEventArgs e) { OpenWebsite("https://github.com/3alTemp/"); }
		private void World_Click(object sender, RoutedEventArgs e) { OpenWebsite("https://trialtemp.com/twiforked/"); }
	}
}
