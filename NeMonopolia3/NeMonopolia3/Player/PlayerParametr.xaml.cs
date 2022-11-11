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
            playerName.Text = Mocks.GetPlayerInfo().Name;
            StopsLeft.Text = "Остановок до бонуса: " + (5 - Mocks.GetPlayerCharacteristic().StopCount).ToString();
            l1.Text = "Деньги: " + Mocks.GetPlayerCharacteristic().Money;
            l2.Text = "Интеллект: " + Mocks.GetPlayerCharacteristic().Intellect;
            l3.Text = "Честность: " + Mocks.GetPlayerCharacteristic().Honesty;
            l4.Text = "Удача: " + Mocks.GetPlayerCharacteristic().Luck;
            l5.Text = "Коммуникабельность: " + Mocks.GetPlayerCharacteristic().Communication;
        }
    }
}

