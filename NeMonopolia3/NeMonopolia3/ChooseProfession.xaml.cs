using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class ChooseProfession : ContentPage
    {
        public ChooseProfession()
        {
            InitializeComponent();

        }
        public Pers thelast = new Pers();
        protected override async void OnAppearing()
        {
            base.OnAppearing();
           // CurrentPlayerData.CurPlayer.Persons = new List<Pers>();
            thelast = CurrentPlayerData.CurPlayer.Persons.Last();
            thelast.idGame =CurrentPlayerData.CurGame.idGame;
            thelast.idPlayer = CurrentPlayerData.CurPlayer.idPlayer;
            thelast.Money = 500000;
            thelast.NickName = "SUBO";
            thelast.StopCount = 0;
            thelast.isPlaying = true;
            
        }

        async void S_Clicked(System.Object sender, System.EventArgs e)
        {
            //var luck = sender.GetType().Name + "Luc";
            //var comunication = sender.GetType().Name + "Com";
            //var honesty = sender.GetType().Name + "Hon";
            //var intellect = sender.GetType().Name + "Int";

            //object wantedNode = FindByName(luck);
            //var net = wantedNode as Label;            
            //var str = net.Text
            //Pers person = new Pers() { };
            
            thelast.Luck = 20;
            thelast.Communication = 40;
            thelast.Intellect = 55;
            thelast.Honesty = 80;
            thelast.Holds = new List<Hold>();
            CurrentPlayerData.CurPers = thelast;
            CurrentPlayerData.CurPlayer.Persons.Add(thelast);
            await Navigation.PushAsync(new TabPage());

        }

        async void  V_Clicked(System.Object sender, System.EventArgs e)
        {
            thelast.Luck = 55;
            thelast.Communication = 45;
            thelast.Intellect = 30;
            thelast.Honesty = 20;
            thelast.Holds = new List<Hold>();
            CurrentPlayerData.CurPers = thelast;
            CurrentPlayerData.CurPlayer.Persons.Add(thelast);
            await Navigation.PushAsync(new TabPage());

        }

        async void D_Clicked(System.Object sender, System.EventArgs e)
        {
            thelast.Luck = 30;
            thelast.Communication =80 ;
            thelast.Intellect = 20;
            thelast.Honesty = 35;
            thelast.Holds = new List<Hold>();
            CurrentPlayerData.CurPers = thelast;
            CurrentPlayerData.CurPlayer.Persons.Add(thelast);
            await Navigation.PushAsync(new TabPage());
        }

        async void R_Clicked(System.Object sender, System.EventArgs e)
        {

            thelast.Luck = 80;
            thelast.Communication = 30;
            thelast.Intellect = 25;
            thelast.Honesty = 70;
            thelast.Holds = new List<Hold>();
            CurrentPlayerData.CurPers = thelast;
            CurrentPlayerData.CurPlayer.Persons.Add(thelast);
            await Navigation.PushAsync(new TabPage());
        }

        async void M_Clicked(System.Object sender, System.EventArgs e)
        {
            thelast.Luck = 10;
            thelast.Communication = 55;
            thelast.Intellect = 80;
            thelast.Honesty = 30;
            thelast.Holds = new List<Hold>();
            CurrentPlayerData.CurPers = thelast;
            CurrentPlayerData.CurPlayer.Persons.Add(thelast);
            await Navigation.PushAsync(new TabPage());
        }
    }
}

