using System;
using System.Diagnostics;
using System.Threading.Tasks;
using test2.Models;
using Xamarin.Forms;

namespace test2.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string Nombre;
        private string Edad;
        private string Email;
        private string Ciudad;
        public string Id { get; set; }
        public ItemDetailViewModel(string nombre)
        {
            this.Nombre = nombre;
        }

        public ItemDetailViewModel()
        {
        }

        

        public string Nom
        {
            get => Nom;
            set => SetProperty(ref Nombre, value);
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

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Nom = item.Nombre;
                Age= item.Edad;
                Mail = item.Email;
                City= item.Ciudad;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
