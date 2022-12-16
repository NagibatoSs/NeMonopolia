using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static Xamarin.Forms.Internals.GIFBitmap;

namespace NeMonopolia3
{
    public partial class ActionView : ContentPage
    {
        FactoryInf Factory = new FactoryInf();
        Pers Player = new Pers();
        Stop stop = new Stop();
        Factory factory = new Factory();
        public ActionView()
        {
            InitializeComponent();
        }
        public ActionView(Stop stop)
        {
            this.stop = stop;
            factory = this.stop.factory[0];
        }
        protected override void OnAppearing()
        {
            //var aa = App.DataBase.GetPlayers();
            
            //Player = aa[0];
            ////получаем здесь экземпляр фактори
            //// Factory = new Factory();
            //Factory = FillTheFacroty(Factory);

            pBalance.Text += factory.Holds[0].Pers.Money;
            fName.Text = stop.TItle;
            fPrice.Text = "Цена: " + factory.BasePrice.ToString();
            fRent.Text = "Базовая рента: " + factory.Rates[0].Rent.ToString();
            fSecurity.Text = "Охраняемость: " + factory.Rates[0].Security.ToString() + "%";
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // Player = App.DataBase.GetPlayers()[0];

            // Manipulation.BuyFactory(factory.Holds[0], Factory);
            await DisplayAlert("Успешная покупка", "Вы купили предприятие " + Factory.Name + "!", "ОК");
            await Navigation.PopAsync();

        }

       public async  void Button_Clicked_1(System.Object sender, System.EventArgs e)
       {
          //  Player = App.DataBase.GetPlayers()[0];
            //Manipulation.SellingToBank(Player, Factory);
            await DisplayAlert("Успешная продажа", "Вы продали предприятие " + Factory.Name + " за "
                + Factory.Price/2 +"!!", "ОК");
            await Navigation.PopAsync();
       }

       public async void Button_Clicked_2(System.Object sender, System.EventArgs e)
        { 
            await DisplayAlert("Пропуск", "Вы упустили возможность покупки предприятия"
               + "!!!" , "ОК");
            //await Navigation.PushAsync(new Map());
           await Navigation.PopAsync();


        }
        public FactoryInf FillTheFacroty(FactoryInf factory)
        {
            factory.Id = 1;
            factory.Name = "KFC";
            factory.Price = 500000;
            factory.Rent = 10000;
            factory.Image = "KFC.jpg";
            factory.Security = 20;
            factory.OwnerId = 0;
            factory.ChangerIntellect = 10;
            factory.ChangerHonesty = 0;
            factory.ChangerCommunication = 5;
            factory.ChangerLuck = 15;
            return factory;
        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            string text = "Вы находитесь в окне действия. " +
                "Здесь можете выбрать три действия: " +
                " 1. Кнопка 'Купить' позволяет купить предприятие на котором вы находитесь. " +
                " 2. Кнопка 'Продать' позоваляет вам продать банку предприятие в случае ранней покупки. " +
                "Предприятие будет продано за половину стоимости покупи предприятия. " +
                " 3. Кнопка 'Пропустить' позоваляет пропустить ход. То есть никаких действии не произойдет. Ход будет завершен. " +
                "Также на экране можете увидеть информацию о предприятии. " +
                "Охраняемость влияет на что-то хз на что честно говря " +
                "Базовая рента показывает сколько нужно заплатить владельцу при выходе на эту остановку" +
                "В нижней части экрана показан ваш текущий баланс. " +
                "Удачи вам! " +
                "Бойтесь коробейникова " +
                "делайте лабы во время " +
                "на этом все " +
                "желаю вашим близким и родным здаровья " +
                "если что здОровья " +
                "это русский язые чувак" +
                "полный кринж" +
                "var зашквар" +
                "(с) Коробейников " +
                "безумно можно быть первыыым"

                ;
            DisplayAlert("Подсказка",text,"Понял");
        }
    }
}
    