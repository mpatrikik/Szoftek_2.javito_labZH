using MPatrik_RQ8RD0_2.labjavZH.ViewModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPatrik_RQ8RD0_2.labjavZH.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomePageVM();
            Debug.WriteLine($"BindingContext set to: {BindingContext.GetType().Name}");
            NavigationPage.SetHasNavigationBar(this, false);
            Debug.WriteLine($"BindingContext is set to: {BindingContext}");
        }
    }
}