using MPatrik_RQ8RD0_2.labjavZH.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace MPatrik_RQ8RD0_2.labjavZH.ViewModel
{
    public class RegistrationPageVM
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand RegisterCommand { get; }
        public RegistrationPageVM()
        {
            RegisterCommand = new Command(() =>
            {
                var newUser = new User
                {
                    Username = this.Username,
                    Password = this.Password,
                };

                Application.Current.MainPage.DisplayAlert("Done", "Succesfull registration!", "OK");
                Application.Current.MainPage.Navigation.PopAsync();
            });
        }
    }
}