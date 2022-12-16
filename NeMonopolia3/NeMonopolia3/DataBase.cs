using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace NeMonopolia3
{
    public class DataBase
    {
        private readonly SQLiteConnection database;
        public DataBase(string dbPath)
        {
            //database = new SQLiteConnection(dbPath);

            //database.CreateTable<PlayerInfo>();
            //database.CreateTable<PlayerCharacteristic>();
            //database.CreateTable<Factory>();
        }
        //public void UpdateChildern(PlayerCharacteristic playerCharacteristic)
        //{
        //    database.UpdateWithChildren(playerCharacteristic);
        //}
        public void UpdateChildrens<T>(T playerCharacteristic)
        {
            database.UpdateWithChildren(playerCharacteristic);
        }

        ///Getting 
        public List<PlayerCharacteristic> GetPlayers()
        {
            return database.GetAllWithChildren<PlayerCharacteristic>();
        }

        public List<FactoryInf> GetFactories()
        {
            return database.GetAllWithChildren<FactoryInf>();
        }

        public List<PlayerInfo> GetPlayerInfo()
        {
            return database.GetAllWithChildren<PlayerInfo>();
        }

        public List<PlayerCharacteristic> GetPlayerAsync()
        {
            return database.Table<PlayerCharacteristic>().ToList();
        }


        ///Saving
        public void SaveChildrens<T>(List<T> player)
        {
            database.InsertAllWithChildren(player);
        }


        /// ID

        public PlayerCharacteristic GetPlayerCharacById(int id)
        {
            return database.GetAllWithChildren<PlayerCharacteristic>().Where(i => i.Id == id).FirstOrDefault();
            //return database.Table<PlayerCharacteristic>().Where(i => i.Id == id).FirstOrDefault();
        }
        public FactoryInf GetFactoryById(int id)
        {
            return database.GetAllWithChildren<FactoryInf>().Where(i => i.Id == id).FirstOrDefault();
        }
        public PlayerInfo GetPlayerInfoById(int id)
        {
            return database.GetAllWithChildren<PlayerInfo>().Where(i => i.Id == id).FirstOrDefault();
        }

    }
}

