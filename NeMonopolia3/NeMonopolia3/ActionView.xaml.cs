using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Xamarin.Forms.Internals.GIFBitmap;

namespace NeMonopolia3
{
    public partial class ActionView : ContentPage
    {
        Factory Factory = new Factory();
        PlayerCharacteristic Player = new PlayerCharacteristic();
        public ActionView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var aa = App.DataBase.GetPlayers();
            Player = aa[0];
            //получаем здесь экземпляр фактори
            // Factory = new Factory();
            Factory = FillTheFacroty(Factory);
            fName.Text = Factory.Name;
            fPrice.Text = "Цена: " + Factory.Price.ToString();
            fRent.Text = "Базовая рента: " + Factory.rent.ToString();
            fSecurity.Text = "Охраняемость: " + Factory.security.ToString() + "%";
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Player = App.DataBase.GetPlayers()[0];
            Manipulation.BuyFactory(Player, Factory);
            await DisplayAlert("Успешная покупка", "Вы купили предприятие " + Factory.Name + "!", "ОК");
            await Navigation.PopAsync();

        }

       public async  void Button_Clicked_1(System.Object sender, System.EventArgs e)
       {
            Player = App.DataBase.GetPlayers()[0];
            Manipulation.SellingToBank(Player, Factory);
            await DisplayAlert("Успешная продажа", "Вы продали предприятие " + Factory.Name + " за "
                + Factory.Price/2 +"!!", "ОК");
            await Navigation.PopAsync();
       }

       public async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        { 
            await DisplayAlert("Пропуск", "Вы упустили возможность покупки предприятия"
               + "!!!" , "ОК");
           // await Navigation.PushAsync(new Map());
            await Navigation.PopAsync();


        }
        public Factory FillTheFacroty(Factory factory)
        {
            factory.Id = 1;
            factory.Name = "KFC";
            factory.Price = 500000;
            factory.rent = 10000;
            factory.Image = "KFC.jpg";
            factory.security = 20;
            factory.OwnerId = 0;
            factory.changerIntellect = 10;
            factory.changerHonesty = 0;
            factory.changerCommunication = 5;
            factory.changerLuck = 15;
            return factory;
        }
    }
}
    