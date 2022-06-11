using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twiforked.Core.Model;

namespace Twiforked.Core
{
	class MainViewModel : ObservableObject
	{
		public SettingsModel _settingsModel { get; set; }

		
		private object _currentView;
		public object CurrentView
		{
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}
		public MainViewModel()
		{
			_settingsModel = new SettingsModel();
			CurrentView = _settingsModel;
		}
	}
}
