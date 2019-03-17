using _02_Lopukhina.Tools.Navigation;
using _02_Lopukhina.ViewModels;

namespace _02_Lopukhina.Views
{
    public partial class LoginHoroscope : INavigatable
    {
        public LoginHoroscope()
        {
            InitializeComponent();
            DataContext = new LoginHoroscopeViewModel();
        }
    }
}
