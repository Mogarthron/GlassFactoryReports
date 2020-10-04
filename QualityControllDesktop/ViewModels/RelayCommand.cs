using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace QualityControllDesktop.ViewModels
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            if (_canExecute == null) return true;
            else return _canExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            _execute(parameter);
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else _execute = execute;

            _canExecute = canExecute;
        }
    }
}
