using System.Windows.Controls;
using _02_Lopukhina.Tools.Managers;
using _02_Lopukhina.Tools.Navigation;
using _02_Lopukhina.ViewModels;

namespace _02_Lopukhina.Views
{
    public partial class MainWindow : IContentOwner
    {
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            NavigationManager.Instance.Initialize(new LoginNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.LoginHoroscope);

        }
    }
}
