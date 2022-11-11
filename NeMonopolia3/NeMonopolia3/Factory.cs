using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace NeMonopolia3
{
    public class Factory
    {
        
        //public enum TypeofFActory
        //{
        //    first,
        //    second,
        //    three
        //}
        public Factory()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int rent { get; set; }
        public int security { get; set; }
        public int bonus { get; set; }
        [ForeignKey(typeof(PlayerCharacteristic))]
        public int OwnerId { get; set; }
       // public TypeofFActory type { get; set; }
       //public PlayerCharacteristic owner { get; set; }

        public int changerIntellect { get; set; }
        public int changerHonesty { get; set; }
        public int changerCommunication { get; set; }
        public int changerLuck { get; set; }
        // public Geo location //locatin with creating class "Geo"
    }
}

