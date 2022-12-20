using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Bag : ContentPage
    {
        public Bag()
        {
            InitializeComponent();
        }


        protected override  void OnAppearing()
        {
            base.OnAppearing();
            var bag = CurrentPlayerData.CurPlayer.Persons.Last().Holds;
            //var test = App.DataBase.GetPlayers();
            //var list = test[0].Portfolio;
            List<Factory> factories = new List<Factory>();
            var changing = new List<FactoryInf>();
            foreach (var e in bag)
                changing.Add(new FactoryInf() { Name =e.Factory.Title, Image =e.Factory.Image, Price = (int)e.Factory.BasePrice,rent = 50000, security = 56 });
            //foreach (var e in bag)
            //    factories.Add(e.Factory);
            myCollectionView.ItemsSource = changing;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await  Navigation.PushAsync(new PlayerParametr());
            
        }
    }
}










//////////////////////     ///////////                     ////////           ////////        //////////////////////
/////////////////////      ////////////                  //////////         ///////////       //////////////////////
///                        ///////  ////               /////   /////      //////     ////      ////////
///                        ///////   /////           //////   //////    ///////     //////     ////////
///                        ///////    /////         /////    ///////   ///////     ////////    ////////
///                        ///////     //////     /////      ///////  ///////      ////////    //////// 
///                        ///////       /////   /////       ///////  ///////     /////////    //////// 
///                        ///////         ////////          ///////  //////      /////////    ////////
/////////////////////      ///////                           ///////  /////////////////////    //////////////////////
/////////////////////      ///////                           ///////  /////////////////////    //////////////////////
///                        ///////                           ///////  //////      /////////    ////////
///                        ///////                           ///////  //////       ////////    ////////
///                        ///////                           ///////  //////       ////////    ////////
///                        ///////                           ///////  //////       ////////    //////// 
///                        ///////                           ///////  //////       ////////    ////////
/////////////////////      ///////                           ///////  //////       ////////    ////////////////////// 
/////////////////////      ///////                           ///////  //////       ////////    //////////////////////