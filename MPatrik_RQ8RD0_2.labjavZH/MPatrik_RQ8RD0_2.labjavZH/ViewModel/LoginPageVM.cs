using MolnarPatrik_RQ8RD0_2.javitolaborZH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MolnarPatrik_RQ8RD0_2.javitolaborZH.ViewModel
{
    public class LoginPageVM : ContentPage
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }
        public LoginPageVM()
        {
            LoginCommand = new Command(() =>
            {
                bool isValid = UserStore.ValidateUser(Username, Password);

                if (isValid)
                {
                    Application.Current.MainPage.DisplayAlert("Done", "Login successfully!", "OK");
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Incorrect username or password!", "OK");
                }
            });
        }
    }
}