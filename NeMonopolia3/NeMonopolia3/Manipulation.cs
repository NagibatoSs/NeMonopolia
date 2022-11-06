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
            if (factory.owner != null)
            {
                PayRent(player, factory);
            }

            if (player.Money < factory.Price)
            {
                return; //not enough money maan можно эксептион
            }
            player.Money = player.Money - factory.Price;
            ///
            player.Portfolio = new List<Factory>();
            player.Portfolio.Add(factory);
            
            bag.Refresh(player.Portfolio);

        }

        public static void PayRent(PlayerCharacteristic visitor, Factory factory)
        {
            if (visitor.Money < factory.rent)
            {
                Loosing(visitor);
                return; //BANCROT MAFFAKA
            }
             visitor.Money = visitor.Money - factory.Price;
            factory.owner.Money = factory.owner.Money + factory.rent;
        }

        public static void Loosing(PlayerCharacteristic player)
        {
            player.IsPlaying = false;
            foreach (var factory in player.Portfolio)
            {
                factory.owner = null;
            }
            player.Portfolio = null;
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
            factory.owner.Money += factory.Price / 2;
            var deleting = factory.owner.Portfolio.Where(f => f.Id == factory.Id);
            factory.owner.Portfolio.Remove(deleting.First()); ///take it easy maaaaaaaaaaaaaaaaaaaan
            factory.owner = null;  ///levell find ...

        }



    }

}

