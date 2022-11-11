using System;
using System.Collections.Generic;
using System.Linq;

namespace NeMonopolia3
{
    public class Manipulation
    {
        public Manipulation()
        {
        }
        const int BonusSum = 5000;
        static Bag bag = new Bag();
        public static void BuyFactory(PlayerCharacteristic player, Factory factory)
        {
            if (factory.OwnerId != 0) ///// warning null is not sutible need start with 0
            {
                PayRent(player, factory);
            }

            if (player.Money < factory.Price)
            {
                return; //not enough money maan можно эксептион
            }
            player.Money = player.Money - factory.Price;

            /////
         //   player.PortfolioId = new List<int>();
         //   player.PortfolioId.Add(factory.Id);

            //bag.Refresh(player.Portfolio);

        }

        public static void PayRent(PlayerCharacteristic visitor, Factory factory)
        {
            if (visitor.Money < factory.rent)
            {
                Loosing(visitor);
                return; //BANCROT MAFFAKA
            }
             visitor.Money = visitor.Money - factory.Price;
            int id = factory.OwnerId;
            var owner =  App.DataBase.GetPlayerCharacById(id);
            owner.Money += factory.rent;
        }

        public static void Loosing(PlayerCharacteristic player)
        {


            player.IsPlaying = false;
            //foreach (var factoryid in player.PortfolioId)
            //{
            //    // factory.owner = null;
            //    var factory = App.DataBase.GetFactoryById(factoryid);
            //    factory.OwnerId = 0;
              
            //}
            //player.PortfolioId = null;
        }
        public static int SumRent()
        {
            return 1;
        }
        public static void ChangeCharacteristics(PlayerCharacteristic player, Factory factory)
        {
            //создать класс характеристик в виде справочника
            player.Honesty += factory.changerHonesty;
            player.Intellect += factory.changerIntellect;
            player.Communication += factory.changerCommunication;
            player.Luck += factory.changerLuck;
        }
        public static void CheckBonus(PlayerCharacteristic player)
        {
            if (player.StopCount == 5)
            {
                player.Money += BonusSum;
                player.StopCount = 0;
            }
        }
        public static void SellingToBank(Factory factory)
        {
            var player = App.DataBase.GetPlayerCharacById(factory.OwnerId);
            player.Money += factory.Price / 2;
            
           // var deleting = player.PortfolioId.Where(f => f == factory.Id);
            //player.PortfolioId.Remove(deleting.First()); ///take it easy maaaaaaaaaaaaaaaaaaaan
            factory.OwnerId = 0;  ///levell find ...

        }



    }

}

