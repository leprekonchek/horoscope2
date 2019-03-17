using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using _02_Lopukhina.Models;
using _02_Lopukhina.Tools;
using _02_Lopukhina.Tools.Managers;
using _02_Lopukhina.Tools.Navigation;

namespace _02_Lopukhina.ViewModels
{
    class CabinetViewModel : INotifyPropertyChanged
    {
        #region Fields

        private Person _person = StationManager.CurrentPerson;
        private RelayCommand<object> _backCommand;

        #endregion

        public Person Person
        {
            get { return _person; }
        }

        public RelayCommand<Object> BackCommand
        {
            get
            {
                return _backCommand ?? (_backCommand = new RelayCommand<object>(
                           o => { NavigationManager.Instance.Navigate(ViewType.LoginHoroscope); }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
