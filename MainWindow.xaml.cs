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

		private void Minimize_Click(object sender, RoutedEventArgs e) { WindowState = WindowState.Minimized; }
		private void Close_Click(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
		private void NulFunc_Click(object sender, RoutedEventArgs e) { return; }
		private void About_Click(object sender, RoutedEventArgs e)
		{
			// Instance and show an "AppInfo" window
			AppInfo w = new AppInfo();
			w.Owner = this;
			w.Show();
		}
	}
}
