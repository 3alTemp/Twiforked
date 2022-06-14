using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Twiforked
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow(){InitializeComponent();}

		private void Border_MouseDown(object sender, MouseButtonEventArgs e)
		{   // Drag the window when hold-clicking the top border
			if (Mouse.LeftButton == MouseButtonState.Pressed)
				DragMove();
		}

		// Generic functions
		private void Minimize_Click(object sender, RoutedEventArgs e) { WindowState = WindowState.Minimized; }
		private void Close_Click(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
		private void NulFunc_Click(object sender, RoutedEventArgs e) { return; }

		private void About_Click(object sender, RoutedEventArgs e)
		{
			// Check if there's already an instance of "AppInfo" running, if not: instance
			if (Application.Current.Windows.OfType<AppInfo>().FirstOrDefault() != null) return;

			// Instance
			var w = new AppInfo();
			w.Owner = this;
			w.Show();
		}
	}
}
