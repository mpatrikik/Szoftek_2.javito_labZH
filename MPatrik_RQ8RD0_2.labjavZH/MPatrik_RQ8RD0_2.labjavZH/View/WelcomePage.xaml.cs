using MolnarPatrik_RQ8RD0_2.javitolaborZH.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolnarPatrik_RQ8RD0_2.javitolaborZH.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomePageVM();
        }
    }
}