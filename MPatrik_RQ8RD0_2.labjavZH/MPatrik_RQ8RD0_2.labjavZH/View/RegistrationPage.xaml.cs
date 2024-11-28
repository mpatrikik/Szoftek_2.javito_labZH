using MPatrik_RQ8RD0_2.labjavZH.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MPatrik_RQ8RD0_2.labjavZH.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = new RegistrationPageVM();
        }
    }
}