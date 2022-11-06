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
            Refresh(fa);
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

