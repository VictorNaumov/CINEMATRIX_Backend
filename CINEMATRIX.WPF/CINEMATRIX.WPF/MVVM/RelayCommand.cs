using CINEMATRIX.WPF.Helpers;
using System;
using System.Windows.Input;

namespace CINEMATRIX.WPF.MVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action _executeMethod;
        private readonly Func<bool> _canExecuteMethod;


        public RelayCommand(Action executeMethod, Func<bool> canExecuteMethod = null)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }


        public void Execute()
        {
            Execute(null);
        }

        public bool CanExecute()
        {
            return CanExecute(null);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteMethod == null || _canExecuteMethod();
        }

        public void Execute(object parameter)
        {
            Execute(_executeMethod, parameter, _executeMethod);
        }



        public event EventHandler CanExecuteChanged
        {
            add
            {
                InternalCanExecuteChanged += value;
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                InternalCanExecuteChanged -= value;
                CommandManager.RequerySuggested -= value;
            }
        }

        private event EventHandler InternalCanExecuteChanged;


        public void RaiseCanExecuteChanged()
        {
            if (_canExecuteMethod != null)
                OnCanExecuteChanged();
        }

        private void OnCanExecuteChanged()
        {
            var temp = InternalCanExecuteChanged;
            temp?.Invoke(this, EventArgs.Empty);
        }



        protected void Execute(Delegate method, object parameter, Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                LogHelper.Error($"Failed to execute {this} command", exception);
            }

        }
    }
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _executeMethod;
        private readonly Func<T, bool> _canExecuteMethod;


        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod = null)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }


        public void Execute()
        {
            Execute(null);
        }

        public bool CanExecute()
        {
            return CanExecute(null);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteMethod == null || _canExecuteMethod(Cast(parameter));
        }

        private static T Cast(object parameter)
        {
            if (parameter is T)
            {
                return (T)parameter;
            }
            try
            {
                return (T)Convert.ChangeType(parameter, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default;
            }

        }

        public void Execute(object parameter)
        {
            Execute(_executeMethod, Cast(parameter), _executeMethod);
        }


        public event EventHandler CanExecuteChanged
        {
            add
            {
                InternalCanExecuteChanged += value;
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                InternalCanExecuteChanged -= value;
                CommandManager.RequerySuggested -= value;
            }
        }

        private event EventHandler InternalCanExecuteChanged;


        public void RaiseCanExecuteChanged()
        {
            if (_canExecuteMethod != null)
                OnCanExecuteChanged();
        }

        private void OnCanExecuteChanged()
        {
            var temp = InternalCanExecuteChanged;
            temp?.Invoke(this, EventArgs.Empty);
        }



        protected void Execute(Delegate method, T parameter, Action<T> action)
        {
            try
            {
                action(parameter);
            }
            catch (Exception exception)
            {
                LogHelper.Error($"Failed to execute {this} command", exception);
            }

        }
    }


}
