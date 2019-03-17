namespace _02_Lopukhina.Tools.Navigation
{
    internal enum ViewType
    {
        Cabinet,
        LoginHoroscope
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
