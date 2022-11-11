using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace NeMonopolia3
{
    public class PlayerCharacteristic
    {
        public PlayerCharacteristic()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id {get;set;}
        public int PlayerId { get; set; }
       // public PlayerInfo Account { get; set; }
        public int Money { get; set; }
        public int Intellect { get; set; }
        public int Honesty { get; set; }
        public int Communication { get; set; }
        public int Luck { get; set; }
        public int Rank { get; set; }
        public int PortfolioId;
        //public SQLite.TableQuery<Factory> PortfolioId;
        // public List<int> PortfolioId { get; set; }
        [OneToMany]
        public  List<Factory> Portfolio { get; set; }
        public bool IsPlaying { get; set; }
        public int StopCount { get; set; }
    }
}

