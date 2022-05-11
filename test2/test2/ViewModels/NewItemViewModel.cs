using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using test2.Models;
using Xamarin.Forms;

namespace test2.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string nombre;
        private string Edad;
        public string Email;
        public string Ciudad;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nombre)
                && !String.IsNullOrWhiteSpace(Email) ;
        }

        public string Nom
        {
            get => Nom;
            set => SetProperty(ref nombre, value);
        }

        public string Age
        {
            get => Age;
            set => SetProperty(ref Edad, value);
        }
        public string Mail
        {
            get => Mail;
            set => SetProperty(ref Email, value);
        }
        public string City
        {
            get => City;
            set => SetProperty(ref Ciudad, value);
        }
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = nombre,
                Edad = Edad,
                Email = Email,
                Ciudad = Ciudad
                
                
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
