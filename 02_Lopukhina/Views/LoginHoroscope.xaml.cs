using System.Windows.Controls;
using _02_Lopukhina.Tools.Navigation;
using _02_Lopukhina.ViewModels;

namespace _02_Lopukhina.Views
{
    public partial class LoginHoroscope : UserControl, INavigatable
    {
        public LoginHoroscope()
        {
            InitializeComponent();
            DataContext = new LoginHoroscopeViewModel();
        }
    }
}
