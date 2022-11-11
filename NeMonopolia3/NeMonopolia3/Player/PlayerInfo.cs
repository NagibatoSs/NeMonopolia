using System;
using System.Collections.Generic;
using SQLite;

namespace NeMonopolia3
{
    public class PlayerInfo
    {
        public PlayerInfo()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id {get;set;}
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
       // public List<int> SessionsId { get; set; }
      //  public List<PlayerCharacteristic> Sessions { get; set; }
    }
}

