using System.Windows;
using CRUDApp.ViewModel;

namespace CRUDApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs eventArgs) {
            MessageBox.Show("Welcome to WPF");
            ((MainViewModel)this.DataContext).HelloText = "Button has been pressed";
        }
    }
}
