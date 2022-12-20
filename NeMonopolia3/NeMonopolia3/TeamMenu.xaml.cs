using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class TeamMenu : ContentPage
    {
        public TeamMenu()
        {
            InitializeComponent();
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            var idTeam = int.Parse(id.Text);
            DBContext.GetGameById(idTeam);
            CurrentPlayerData.CurGame.Pers = new List<Pers>();

            CurrentPlayerData.CurGame.Pers.Add(await DBContext.GetPersonById(1));
            if (CurrentPlayerData.CurGame.Title != null)
            {
                DisplayAlert("Поздравляю", "Вы успешно вошли в команду", "ОК");
                await Navigation.PushAsync(new ChooseProfession());
            }
            else
            {
                DisplayAlert("Предупреждение","Вы указали неверный id","ОК");
            }
            
        }
    }
}

