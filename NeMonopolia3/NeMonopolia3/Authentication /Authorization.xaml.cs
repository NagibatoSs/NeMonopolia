using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Authorization : ContentPage
    {
        public Authorization()
        {
            InitializeComponent();
            Iconimage.Source = ImageSource.FromFile("newicon.png");
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PlayerProfile());
        }

        private async void  Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }
    }
}

