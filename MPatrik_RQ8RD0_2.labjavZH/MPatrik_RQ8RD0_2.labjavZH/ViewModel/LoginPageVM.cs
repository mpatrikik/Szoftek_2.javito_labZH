using System.Windows.Input;
using Xamarin.Forms;

namespace MPatrik_RQ8RD0_2.labjavZH.ViewModel
{
    public class LoginPageVM : ContentPage
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }
        public LoginPageVM()
        {
        }
    }
}