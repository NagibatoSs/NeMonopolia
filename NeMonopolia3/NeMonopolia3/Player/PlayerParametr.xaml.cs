using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
            playerName.Text = "TATARIN";
            StopsLeft.Text = "Остановок до бонуса: " + (5 - App.DataBase.GetPlayers()[0].StopCount).ToString();
            l1.Text = "Деньги: " + App.DataBase.GetPlayers()[0].Money;
            l2.Text = "Интеллект: " + App.DataBase.GetPlayers()[0].Intellect;
            l3.Text = "Честность: " + App.DataBase.GetPlayers()[0].Honesty;
            l4.Text = "Удача: " + App.DataBase.GetPlayers()[0].Luck;
            l5.Text = "Коммуникабельность: " + App.DataBase.GetPlayers()[0].Communication;
        }
    }
}

