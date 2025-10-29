using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMauiApp.Commands;

// RelayCommand bez parametru
public class RelayCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public RelayCommand(Action execute, Func<bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        // return _canExecute == null ? true : _canExecute.Invoke();

        return _canExecute == null || _canExecute.Invoke();
    }

    public void Execute(object? parameter)
    {
        //if (_execute != null)
        //    _execute.Invoke();

        _execute?.Invoke();

    }
}

// RelayCommand z parametrem
public class RelayCommand<T> : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private readonly Action<T> _execute;
    private readonly Func<T, bool> _canExecute;

    public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        // return _canExecute == null ? true : _canExecute.Invoke();

        return _canExecute == null || _canExecute.Invoke((T) parameter);
    }

    public void Execute(object? parameter)
    {
        //if (_execute != null)
        //    _execute.Invoke();

        _execute?.Invoke((T) parameter);

    }
}
