using System;
using System.Linq;

namespace NeMonopolia3
{
    public class Manipulation
    {
        public Manipulation()
        {
        }
        const int BonusSum=5000;
        public void BuyFactory(PlayerCharacteristic player,Factory factory)
        {
            if (factory.owner != null)
            {
                PayRent(player, factory);
            }

            if (player.Money < factory.price)
            {
                return; //not enough money maan можно эксептион
            }
            player.Money = player.Money - factory.price;

        }

        public void PayRent(PlayerCharacteristic visitor,Factory factory)
        {
            if (visitor.Money < factory.rent)
            {
                Loosing(visitor);
                return; //BANCROT MAFFAKA
            }
            visitor.Money = visitor.Money - factory.price;
            factory.owner.Money = factory.owner.Money + factory.rent;
        }

        public void Loosing(PlayerCharacteristic player)
        {
            player.IsPlaying = false;
            foreach(var factory in player.Portfolio)
            {
                factory.owner = null;
            }
            player.Portfolio = null;
        }
        public int SumRent()
        {
            return 1;
        }
        public void ChangeCharacteristics(PlayerCharacteristic player, Factory factory)
        {
            //создать класс характеристик в виде справочника
            player.Honesty += factory.changerHonesty;
            player.Intellect += factory.changerIntellect;
            player.Communication += factory.changerCommunication;
            player.Luck += factory.changerLuck;
        }
        public void CheckBonus(PlayerCharacteristic player)
        {
            if (player.StopCount == 5)
            {
                player.Money += BonusSum;
                player.StopCount = 0;
            }
        }
        public void SellingToBank(Factory factory)
        {
            factory.owner.Money += factory.price / 2;
            var deleting = factory.owner.Portfolio.Where(f => f.id == factory.id);
            factory.owner.Portfolio.Remove(deleting.First()); ///take it easy maaaaaaaaaaaaaaaaaaaan
            factory.owner = null;  ///levell find ...
            
        }


       
    }

}

