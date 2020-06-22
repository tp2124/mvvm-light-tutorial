using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs;

namespace CRUDApp.ViewModel
{
    public class ChangeMessageVM : ViewModelBase, IModalDialogViewModel
    {
        private readonly RelayCommand _okCommand;

        private string _message;
        private bool? _dialogResult;

        public ChangeMessageVM()
        {
            _okCommand = new RelayCommand(Ok, CanOk);
        }

        public string Message
        {
            get => _message;
            set
            {
                Set(nameof(Message), ref _message, value);

                _okCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand OkCommand => _okCommand;

        public bool? DialogResult
        {
            get => _dialogResult;
            private set => Set(nameof(DialogResult), ref _dialogResult, value);
        }

        private void Ok()
        {
            if (!string.IsNullOrEmpty(Message))
            {
                DialogResult = true;
            }
        }

        private bool CanOk()
        {
            return !string.IsNullOrWhiteSpace(Message);
        }
    }
}