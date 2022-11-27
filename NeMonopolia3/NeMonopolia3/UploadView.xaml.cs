using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class UploadView : ContentPage
    {
        public UploadView()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //DataLoading.PlayerAdd();
            //DataLoading.FactoryAdd();
            var show = App.DataBase.GetPlayers();
            var showFacrory = App.DataBase.GetFactories();
        }
    }
}

