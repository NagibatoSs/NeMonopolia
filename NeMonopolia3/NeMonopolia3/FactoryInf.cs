using System;
using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace NeMonopolia3
{
    public class FactoryInf
    {
        //public enum TypeofFActory
        //{
        //    first,
        //    second,
        //    three
        //}
        public FactoryInf()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Rent { get; set; }
        public int Security { get; set; }
        public int Bonus { get; set; }
        [ForeignKey(typeof(PlayerCharacteristic))]
        public int OwnerId { get; set; }
        // public TypeofFActory type { get; set; }
        //public PlayerCharacteristic owner { get; set; }

        public int ChangerIntellect { get; set; }
        public int ChangerHonesty { get; set; }
        public int ChangerCommunication { get; set; }
        public int ChangerLuck { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public int LevelOfFactory { get; set; }
        public virtual PlayerCharacteristic Owner { get; set; }
        // public Geo location //locatin with creating class "Geo"

        ///
    }
}

