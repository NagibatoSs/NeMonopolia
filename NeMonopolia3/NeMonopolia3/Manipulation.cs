using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Xamarin.Forms;
namespace NeMonopolia3
{
    public class Manipulation
    {
        public Manipulation()
        {
        }
        const int BonusSum = 5000;
        static Bag bag = new Bag();

        public static void BuyFactory(Hold hold, Factory factory)
        {
            //hold.idFactory==factory.idFactory
            //hold.Pers.idPers != hold.factory.OwnerId
            //factory.Holds == null
            if ((factory.Holds != null || factory.Holds.Count !=0) && (hold.idPers != CurrentPlayerData.CurPlayer.Persons.Last().idPers)) ///// warning null is not sutible need start with 0
            {
                
                PayRent(CurrentPlayerData.CurPlayer.Persons.Last(), factory);
            }

            if (CurrentPlayerData.CurPlayer.Persons.Last().Money < factory.BasePrice)
            {
                return; //not enough money maan можно эксептион
            }
            CurrentPlayerData.CurPlayer.Persons.Last().Money = CurrentPlayerData.CurPlayer.Persons.Last().Money - factory.BasePrice;
            //player = ChangeCharacteristics(player, factory);
            //player.Portfolio.Add(factory);
            //App.DataBase.SaveChildrens(new List<FactoryInf> { factory });
            //App.DataBase.UpdateChildrens(factory);
            //App.DataBase.UpdateChildrens(player);
            //var show = App.DataBase.GetPlayers();
            var i = 0;
        }

        //public async void Alerting()
        //{
        //    await DisplayAlert
        //}

        public static void PayRent(Pers visitor, Factory factory)
        {
            if (visitor.Money < factory.Rates[0].Rent)
            {
                //Loosing(visitor);
                return; //BANCROT MAFFAKA
            }
            visitor.Money = visitor.Money - factory.Rates[0].Rent;
            factory.Holds[0].Pers.Money += factory.Rates[0].Rent;
            //int id = factory.OwnerId;
            //var owner = App.DataBase.GetPlayerCharacById(id);
            //owner.Money += factory.Rent;
        }

        public static void Loosing(PlayerCharacteristic player)
        {

            player.IsPlaying = false;
            //foreach (var factoryid in player.PortfolioId)
            //{
            // // factory.owner = null;
            // var factory = App.DataBase.GetFactoryById(factoryid);
            // factory.OwnerId = 0;

            //}
            //player.PortfolioId = null;
        }
        public static int SumRent()
        {
            return 1;
        }
        public static PlayerCharacteristic ChangeCharacteristics(PlayerCharacteristic player, FactoryInf factory)
        {
            //создать класс характеристик в виде справочника
            player.Honesty += factory.ChangerHonesty;
            player.Intellect += factory.ChangerIntellect;
            player.Communication += factory.ChangerCommunication;
            player.Luck += factory.ChangerLuck;
            return player;
        }
        public static void CheckBonus(PlayerCharacteristic player)
        {
            if (player.StopCount%5 == 0)
            {
                player.Money += BonusSum;
                player.StopCount = 0;
            }
        }
        public static void SellingToBank(PlayerCharacteristic player, FactoryInf factory)
        {            
            player.Money += factory.Price / 2;

            var deleting = player.Portfolio.Where(f => f.Name == factory.Name);
            player.Portfolio.Remove(deleting.First()); ///take it easy maaaaaaaaaaaaaaaaaaaan
            factory.OwnerId = 0; ///levell find ...
            App.DataBase.SaveChildrens(new List<FactoryInf> { factory });
            App.DataBase.UpdateChildrens(factory);
            App.DataBase.UpdateChildrens(player);

        }

    }

}
