using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace CRUDApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        string _ButtonText;
        public string ButtonText { 
            get => _ButtonText;
            set {
                if (!_ButtonText.Equals(value)) {
                    _ButtonText = value;
                    RaisePropertyChanged();
                }
            } 
        }

        public string Title { get { return "Such Diverse WPF App"; } }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// The class gets an instance of The DataAccessService
        /// </summary>
        public MainViewModel(/*IDataAccessService servPxy*/)
        {
            if (IsInDesignMode)
            {
                _ButtonText = "Default Text (Design Mode)";
            }
            else
            {
                _ButtonText = "Default Text";
            }
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
    }
}