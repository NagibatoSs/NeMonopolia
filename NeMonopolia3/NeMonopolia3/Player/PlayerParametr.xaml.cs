using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using System.Linq;
namespace NeMonopolia3
{
    public partial class PlayerParametr : ContentPage
    {
        public PlayerParametr()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
           // DBContext.GetPlayerName(2);

            // playerName.Text = CurrentPlayerData.CurPlayer.Name;
            //StopsLeft.Text = "Остановок до бонуса: " + (5 - App.DataBase.GetPlayers()[0].StopCount).ToString();
            //l1.Text = "Деньги: " + App.DataBase.GetPlayers()[0].Money;
            //l2.Text = "Интеллект: " + App.DataBase.GetPlayers()[0].Intellect;
            //l3.Text = "Честность: " + App.DataBase.GetPlayers()[0].Honesty;
            //l4.Text = "Удача: " + App.DataBase.GetPlayers()[0].Luck;
            //l5.Text = "Коммуникабельность: " + App.DataBase.GetPlayers()[0].Communication;
        
            playerName.Text = CurrentPlayerData.CurPlayer.UserName;
            TeamName.Text = CurrentPlayerData.CurGame.Title;
            TeamId.Text = CurrentPlayerData.CurGame.idGame.ToString();
            StopsLeft.Text = "Остановок до бонуса: " + (5 - CurrentPlayerData.CurPers.StopCount).ToString();
            l1.Text = "Деньги: " + CurrentPlayerData.CurPlayer.Persons.Last().Money.ToString();
            l2.Text = "Интеллект: " + CurrentPlayerData.CurPlayer.Persons.Last().Intellect.ToString();
            l3.Text = "Честность: " + CurrentPlayerData.CurPlayer.Persons.Last().Honesty.ToString();
            l4.Text = "Удача: " + CurrentPlayerData.CurPlayer.Persons.Last().Luck.ToString();
            l5.Text = "Коммуникабельность: " + CurrentPlayerData.CurPlayer.Persons.Last().Communication.ToString();

        }
    }
}

