using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MolnarPatrik_RQ8RD0_2.javitolaborZH.ViewModel
{
    public class WelcomePageVM : ContentView
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