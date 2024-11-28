using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MPatrik_RQ8RD0_2.labjavZH.ViewModel
{
    public class WelcomePageVM
    {
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegistrationCommand { get; }
        public WelcomePageVM()
        {
            NavigateToLoginCommand = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PushAsync(new View.LoginPage());
            });

            NavigateToRegistrationCommand = new Command(() =>
            {
                Application.Current.MainPage.Navigation.PushAsync(new View.RegistrationPage());
            });
        }
    }
}