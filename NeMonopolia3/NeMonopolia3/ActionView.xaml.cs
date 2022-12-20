using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using System.Linq;
using static Xamarin.Forms.Internals.GIFBitmap;
using System.Runtime.CompilerServices;

namespace NeMonopolia3
{
    public partial class ActionView : ContentPage
    {
        FactoryInf Factory = new FactoryInf();
        Pers Player = new Pers();
        Stop stop = new Stop();
        Factory factory = new Factory();
        bool IsChanger=false;
        public ActionView()
        {
            InitializeComponent();
        }
        //public ActionView(Stop stop)
        //{

        //    this.stop = stop;
        //    stop.factory = new List<Factory>();

        //    //DBContext.GetFactory(stop.idStop);
        //    //while (CurrentPlayerData.CurStop.factory == null)
        //    //{
        //    //    Thread.Sleep(1000);

        //    //}

        //    //while (CurrentPlayerData.CurStop.factory.First() == null)
        //    //{
        //    //    Thread.Sleep(1000);

        //    //}
        //    //start
        //    //Factory fac = new Factory() { };

        //    //var list = new List<Factory>();
        //    //list.Add(new Factory() { idFactory = 3, BasePrice = 500000, idStop = 9, Title = "Медецинский центр", Stop = new Stop(), Holds = new List<Hold>(), });
        //    //list.Add(new Factory() { idFactory = 4, BasePrice = 300000, idStop = 6, Title = "ИжГту", Stop = new Stop(), Holds = new List<Hold>(), });
        //    //stop.factory.Add(list[0]);
        //    ////stop.factory.Add(CurrentPlayerData.CurStop.factory[0]);
        //    //stop.factory[0].Holds = new List<Hold>();

        //    //factory = stop.factory[0];
        //    //factory.Holds.Add(new Hold() { Pers = CurrentPlayerData.CurPers, Factory = factory });
        //    //factory.Stop = stop;

        //    //if (stop.chHonesty != null && stop.chIntellect != null && stop.chLuck != null && stop.chCommunication != null)
        //    //{
        //    //    IsChanger = true;
        //    //    buy.Text = "Получить бонус";
        //    //    sell.IsVisible = false;
        //    //}

        //}

        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var aa = App.DataBase.GetPlayers();

            //Player = aa[0];
            ////получаем здесь экземпляр фактори
            //// Factory = new Factory();
            //Factory = FillTheFacroty(Factory);
            Setting();
            omg.Source = factory.Image;
            pBalance.Text += CurrentPlayerData.CurPers.Money.ToString();
            fName.Text = factory.Title;
            if (IsChanger != true) { 
            
            
            fPrice.Text = "Цена: " + factory.BasePrice.ToString();
            fRent.Text = "Базовая рента: " + factory.Rates[0].Rent.ToString();
            fSecurity.Text = "Охраняемость: " + factory.Rates[0].Security.ToString() + "%";
            }


        }
        public void Setting()
        {
            this.stop = CurrentPlayerData.CurStop;
            stop.factory = new List<Factory>();

            Factory fac = new Factory() { };

            // DataOfStop.Loading();
            var list = DataOfStop.list;

            var id = stop.idStop;
            
            var element = list.Where(l => l.idStop == id).ToList();
            stop.factory.Add(element[0]);
            //stop.factory.Add(CurrentPlayerData.CurStop.factory[0]);
            stop.factory[0].Holds = new List<Hold>();

            factory = stop.factory[0];
            factory.Holds.Add(new Hold() { Factory = factory });
            factory.Stop = stop;

            factory.Rates = new List<Rate>();
            factory.Rates.Add(new Rate() { Rent=1000, Factory = factory, idFactory=3, Security=50, });

            if (stop.chHonesty != 0 || stop.chIntellect != 0 || stop.chLuck != 0 || stop.chCommunication != 0)
            {
                IsChanger = true;
                buy.Text = "Получить";
                sell.IsVisible = false;
                //rent.IsVisible = false;
                //secure.IsVisible = false;
                //price.IsVisible = false;
                imageProf.IsVisible = false;
                imageProfTwo.IsVisible = false;
                change.IsVisible = true;
                info.Text = "Характеристики: ";
                //info.FontSize = 14;
                fPrice.Text ="Интеллект: " + stop.chIntellect.ToString();
                fRent.Text ="Удача: " +stop.chLuck.ToString();
                fSecurity.Text = "Честность: " + stop.chHonesty.ToString();
                change.Text ="Коммуникабельность: "+ stop.chCommunication.ToString();
                //fPrice.FontSize = "Medium";
                fPrice.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

            }

        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // Player = App.DataBase.GetPlayers()[0];
            if (IsChanger != true)
            {
                Manipulation.BuyFactory(factory.Holds[0], factory);
                await DisplayAlert("Успешная покупка", "Вы купили предприятие " + factory.Title + "!", "ОК");
                await Navigation.PopAsync();
            }
            else
            {
                Manipulation.ChangeCharacteristics(CurrentPlayerData.CurPers,stop);
                await DisplayAlert("Успешное улучшение", "Ваши характристики улучшены: " +"Честность - "+ CurrentPlayerData.CurPers.Honesty + " Интеллект - "+CurrentPlayerData.CurPers.Intellect +" Комуникабельность - " +CurrentPlayerData.CurPers.Communication + " Удача - "+ CurrentPlayerData.CurPers.Luck , "ОК");

                await Navigation.PopAsync();
            }

        }

       public async  void Button_Clicked_1(System.Object sender, System.EventArgs e)
       {
          //  Player = App.DataBase.GetPlayers()[0];
            Manipulation.SellingToBank(factory.Holds[0], factory);
            await DisplayAlert("Успешная продажа", "Вы продали предприятие " + factory.Title + " за "
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
            factory.rent = 10000;
            factory.Image = "KFC.jpg";
            factory.security = 20;
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
                "В нижней части экрана показан ваш текущий баланс. " 
                ;
            DisplayAlert("Подсказка",text,"Понял");
        }
    }
}
    