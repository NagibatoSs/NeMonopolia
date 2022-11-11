using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Bag : ContentPage
    {
        public Bag()
        {
            InitializeComponent();
        }
        ObservableCollection<Factory> factories;
        public Bag( List<Factory> fa)
        {
            InitializeComponent();
            //Refresh(fa);
            //Refresh();
            //factories = new ObservableCollection<Factory>
            //{
            //    new Factory {Id=1, Price=2}
            //};
            //factories = Mocks.GetFactories();
            //factories = new ObservableCollection<Factory>(Mocks.GetFactories());
            //myCollectionView.ItemsSource = factories;
            //var person = new PlayerCharacteristic();
            //myCollectionView.ItemsSource = person.Portfolio;
        }
        protected override  void OnAppearing()
        {
            
            base.OnAppearing();
           // Added();


            var test = new Factory
            {
                Id = 111,
                Name = "hiTatarstan"
            };
            var listing = new List<Factory>();
            listing.Add(test);

            var element = App.DataBase.GetPlayerTwo();
            var onwlist = element[19];
            App.DataBase.SavePl(listing);
            App.DataBase.Update(onwlist);
            var show = App.DataBase.GetPlayerTwo();
            var i = 1;
            //var test = App.DataBase.GetPlayerTwo();
            //var list = test[17].Portfolio;
            //myCollectionView.ItemsSource = list;

            // Adding();
            // AddingPlayers();
            // Changing(1);
            //var temp = App.DataBase.GetPlayerCharacById(1);
            //var temptwo = temp.PortfolioId;
            //var test = App.DataBase.GetById(temptwo);
            //myCollectionView.ItemsSource = App.DataBase.ToSource(test);
            //  myCollectionView.ItemsSource = App.DataBase.GetPlayerAsync();

        }
        public void Added()
        {
            var test = new Factory
            {
                Id = 4,
                Name = "atatarin"
            };
            var listing = new List<Factory>();
            listing.Add(test);
            var play = new PlayerCharacteristic()
            {
                Id = 6,
                Money = 15500,
               Portfolio = listing
            };
            App.DataBase.SavePlayerCharAsync(play);
            App.DataBase.SavePl(listing);
            App.DataBase.Update(play);
        }
        public  void Adding()
        {
             App.DataBase.SaveFactoryInfoAsync(new Factory
            {
                Id = 1,
                Price = 1000
            }
            );
             App.DataBase.SaveFactoryInfoAsync(new Factory
            {
                Id = 2,
                Price = 2000
            }
        );
            App.DataBase.SaveFactoryInfoAsync(new Factory
            {
                Id = 3,
                Price = 3000
            }
        );
        }
        public void AddingPlayers()
        {
            var Portfol = App.DataBase.GetFactAsync();
            //foreach(var e in Portfol)
            //{
                App.DataBase.SavePlayerCharAsync(new PlayerCharacteristic
                {
                    Id = 1,
                    //var Portfol = App.DataBase.GetFactoryAsync() //save
                    PortfolioId = App.DataBase.SaveF(Portfol)
                }
          );

           // }

           // App.DataBase.SavePlayerCharAsync(new PlayerCharacteristic
           // {
           //     Id = 1,
           //     //var Portfol = App.DataBase.GetFactoryAsync() //save
           //     PortfolioId = App.DataBase.SaveFactoryInfoAsyn()
           // }
           //) ;
       //     App.DataBase.SavePlayerCharAsync(new PlayerCharacteristic
       //     {
       //         Id = 2,
       //         Price = 2000
       //     }
       //);
       //     App.DataBase.SavePlayerCharAsync(new PlayerCharacteristic
       //     {
       //         Id = 3,
       //         Price = 3000
       //     }
       // );
        }

        public void Changing(int id)
        {
            var item = App.DataBase.GetFactoryById(id);
            item.Price = 1500;
        }
        public void Refresh(List<Factory> f)
        {
            factories = new ObservableCollection<Factory>(f);
            myCollectionView.ItemsSource = factories;
        }

        void myCollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            //open the FactoryInfo
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