using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
//using GalaSoft.MvvmLight.Views;
using MvvmDialogs;

namespace CRUDApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        string _buttonText;
        string _messageText;
        string _messageChanged;
        private readonly RelayCommand _changeMessage;
        private readonly IDialogService _dialogService;

        public string ButtonText 
        { 
            get => _buttonText;
            set 
            {
                if (!_buttonText.Equals(value)) {
                    _buttonText = value;
                    RaisePropertyChanged();
                    //Set(nameof(ButtonText), ref _ButtonText, value);
                }
            } 
        }

        public string MessageText
        {
            get => _messageText;
            set
            {
                Set(nameof(MessageText), ref _messageText, value);
            }
        }

        public string MessageChangedNotifcation
        {
            get => _messageChanged;
            set { Set(nameof(MessageChangedNotifcation), ref _messageChanged, value); }
        }

        public ICommand ChangeMessage => _changeMessage;

        public string Title { get { return "Such Diverse WPF App"; } }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// The class gets an instance of The DataAccessService
        /// </summary>
        public MainViewModel(/*IDataAccessService servPxy*/IDialogService dialogService)
        {
            _dialogService = dialogService;
            _changeMessage = new RelayCommand(Add);

            if (IsInDesignMode)
            {
                _buttonText = "Default Text (Design Mode)";
                _messageText = "Lorem Ipsum 100x";
            }
            else
            {
                _buttonText = "Change Message...";
                _messageText = "An initial message to display to people tinkering with WPF.";
            }

            PropertyChanged += MainViewModel_PropertyChanged;

            // _serviceProxy = servPxy;
            // Employees = new ObservableCollection<EmployeeInfo>();
            // EmpInfo = new EmployeeInfo(); 
            // ReadAllCommand = new RelayCommand(GetEmployees);
            // SaveCommand = new RelayCommand<EmployeeInfo>(SaveEmployee);
            // SearchCommand = new RelayCommand(SearchEmployee);
            // SendEmployeeCommand = new RelayCommand<EmployeeInfo>(SendEmployeeInfo);
            // ReceiveEmployeeInfo();

            // public string ButtonMsg { get { return "HelloFromStatic"; } }
        }

        // When property gets changed, raise the PropertyChanged 
        // event of the ViewModel copy of the property
        private void MainViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(MessageText)))
            {
                MessageChangedNotifcation = $"You changed the message to: {MessageText}";
            }
        }

        private void Add()
        {
            var dialogViewModel = new ChangeMessageVM();
            if (_dialogService.ShowDialog<CRUDApp.Views.ChangeMessageDialog>(this, dialogViewModel) ?? false)
            {
                MessageText = dialogViewModel.Message;
            }
        }
    }
}