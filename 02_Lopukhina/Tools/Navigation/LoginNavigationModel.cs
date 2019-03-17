using System;
using _02_Lopukhina.Views;

namespace _02_Lopukhina.Tools.Navigation
{
    internal class LoginNavigationModel : NavigationModel
    {
        public LoginNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.LoginHoroscope:
                    ViewsDictionary.Add(viewType, new LoginHoroscope());
                    break;
                case ViewType.Cabinet:
                    ViewsDictionary.Add(viewType, new Cabinet());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
