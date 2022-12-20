using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
    public class Mocks
    {
        public static PlayerCharacteristic GetPlayerCharacteristic()
        {
            var p = new PlayerCharacteristic();
           // p.Account = GetPlayerInfo();
            p.Money = 1000000;
            p.Intellect = 50;
            p.Honesty = 50;
            p.Communication = 50;
            p.Luck = 50;
            p.Rank = 1;
          //  p.Portfolio = null;
            p.IsPlaying = true;
            p.StopCount = 0;
            return p;
        }

        public static PlayerInfo GetPlayerInfo()
        {
            var p = new PlayerInfo();
            p.Name = "Игорь";
            p.Login = "igorTrasher007";
            p.Password = "123";
           // p.Sessions = new List<PlayerCharacteristic>();
            return p;
        }

        public static List<FactoryInf> GetFactories()
        {
            var f = new FactoryInf();

            f.Id = 1;
            f.Name = "Bank Zenit";
            f.Price = 300000;
            f.rent = 30000;
            f.security = 20;
            f.Bonus = 100;
           // f.Type = Factory.TypeofFActory.first;
            // f.owner = GetPlayerCharacteristic();

            var f1 = new FactoryInf();

            f1.Id = 2;
            f1.Name = "Tatar Bazar";
            f1.Price = 100000;
            f1.rent = 10000;
            f1.security = 10;
            f1.Bonus = 10;
           // f1.Type = Factory.TypeofFActory.second;
            //  f1.owner = GetPlayerCharacteristic();

            var list = new List<FactoryInf>();
            list.Add(f);
            list.Add(f1);
            return list;
        }
    }
}
