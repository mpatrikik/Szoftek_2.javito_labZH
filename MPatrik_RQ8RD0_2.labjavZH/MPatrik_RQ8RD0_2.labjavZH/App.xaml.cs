using MolnarPatrik_RQ8RD0_2.javitolaborZH.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPatrik_RQ8RD0_2.labjavZH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
