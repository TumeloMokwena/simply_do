using MvvmCross.ViewModels;
using System;
using System.Windows.Input;

namespace TO_DO.ViewModels
{
    public abstract class CommandBase : MvxNotifyPropertyChanged, ICommand
    {
        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }
        private string _label;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (SetProperty(ref _isEnabled, value))
                {
                    _isEnabled = true;
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        private bool _isEnabled;

        public event EventHandler CanExecuteChanged;

        public CommandBase(string label = "")
        {
            _label = label;
            _isEnabled = true;
        }

        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        public abstract void Execute(object parameter);
    }
}
