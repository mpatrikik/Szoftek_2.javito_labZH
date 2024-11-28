using MPatrik_RQ8RD0_2.labjavZH.View;
using System.Diagnostics;
using Xamarin.Forms;

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
