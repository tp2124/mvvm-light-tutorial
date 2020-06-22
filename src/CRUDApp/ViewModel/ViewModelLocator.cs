
/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CRUDApp"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/
using GalaSoft.MvvmLight.Ioc;
using MvvmDialogs;

namespace CRUDApp.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<IDialogService>(() => new DialogService());
        }

        public MainViewModel Main => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}