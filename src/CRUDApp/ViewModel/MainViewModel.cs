using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace CRUDApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// The class gets an instance of The DataAccessService
        /// </summary>
        public MainViewModel(/*IDataAccessService servPxy*/)
        {
            // _serviceProxy = servPxy;
            // Employees = new ObservableCollection<EmployeeInfo>();
            // EmpInfo = new EmployeeInfo(); 
            // ReadAllCommand = new RelayCommand(GetEmployees);
            // SaveCommand = new RelayCommand<EmployeeInfo>(SaveEmployee);
            // SearchCommand = new RelayCommand(SearchEmployee);
            // SendEmployeeCommand = new RelayCommand<EmployeeInfo>(SendEmployeeInfo);
            // ReceiveEmployeeInfo();
        }
    }
}