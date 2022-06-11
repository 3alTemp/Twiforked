using System;
using System.Windows.Input;

class RelayCommand : ICommand
{
	private Action<object> exec;
	private Func<object, bool> canExec;

	public event EventHandler CanExecuteChanged
	{
		add { CommandManager.RequerySuggested += value; }
		remove { CommandManager.RequerySuggested -= value; }
	}
	public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) { exec = execute; canExec = canExecute; }
	public bool CanExecute(object p) { return canExec == null || canExec(p); }
	public void Execute(object p) { exec(p); }
}