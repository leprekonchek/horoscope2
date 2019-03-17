using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using _02_Lopukhina.Models;
using _02_Lopukhina.Tools;
using _02_Lopukhina.Tools.Exceptions;
using _02_Lopukhina.Tools.Managers;
using _02_Lopukhina.Tools.Navigation;

namespace _02_Lopukhina.ViewModels
{
    class LoginHoroscopeViewModel : INotifyPropertyChanged
    {
        #region Fields
        private Person _person;

        #region Commands
        private RelayCommand<object> _proceedCommand;
        #endregion
        #endregion

        public LoginHoroscopeViewModel()
        {
            _person = new Person("", "", "");
            StationManager.CurrentPerson = _person;
        }

        #region Properties

        public Person Person
        {
            get => _person;
        }

        #endregion

        #region Commands

        public RelayCommand<object> ProceedCommand =>
            _proceedCommand ?? (_proceedCommand = new RelayCommand<object>(ProceedImplementation, CanProceedExecute));
        #endregion

        private async void ProceedImplementation(object obj)
        {
            LoaderManager.Instance.ShowLoader();
            bool isFinished = await Task.Run(() =>
            {
                StationManager.CurrentPerson = _person;

                try
                {
                    Person.EmailValidation(Person.Email);
                }
                catch (NotValidEmail e)
                {
                    MessageBox.Show($"Email is not valid: {e.Message}");
                    return false;
                }

                try
                {
                    Person.IsAgeCorrect(Person.Age);
                }
                catch (NotBorn e)
                {
                    MessageBox.Show($"Not correct age: {e.Message}");
                    return false;
                }
                catch (OldToBeAlive e)
                {
                    MessageBox.Show($"Not correct age: {e.Message}");
                    return false;
                }

                if (Person.IsBirthday)
                {
                    MessageBox.Show(Person.HbCongratulations);
                }

                return true;
            });
            LoaderManager.Instance.HideLoader();
            if (isFinished)
                NavigationManager.Instance.Navigate(ViewType.Cabinet);
        }

        private bool CanProceedExecute(object obj)
        {
            return !String.IsNullOrEmpty(Person.FirstName) &&
                   !String.IsNullOrEmpty(Person.LastName) &&
                   !String.IsNullOrEmpty(Person.Email);
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
