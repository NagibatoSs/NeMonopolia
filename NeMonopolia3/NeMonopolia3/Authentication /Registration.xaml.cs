using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            Iconimage.Source = ImageSource.FromFile("newicon.png");
            
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Authorization());
        }

        private async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PlayerProfile());
        }
    }
}

