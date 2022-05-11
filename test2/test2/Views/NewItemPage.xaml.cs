using System;
using System.Collections.Generic;
using System.ComponentModel;
using test2.Models;
using test2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}