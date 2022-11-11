using System;
using System.Collections.Generic;
using System.IO;
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
           // var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            database = new SQLiteConnection(dbPath);
            //database.CreateTableAsync<PlayerInfo>();
            //database.CreateTableAsync<PlayerCharacteristic>();
            //database.CreateTableAsync<Factory>();
            
            database.CreateTable<PlayerInfo>();
            database.CreateTable<PlayerCharacteristic>();
            database.CreateTable<Factory>();
        }
        public void Update(PlayerCharacteristic playerCharacteristic)
        {
            database.UpdateWithChildren(playerCharacteristic);
        }
        public List<PlayerCharacteristic> GetPlayerTwo()
        {
            return database.GetAllWithChildren<PlayerCharacteristic>();
        }
        public void SavePl(List<Factory> player)
        {
            database.InsertAllWithChildren(player);
        }
        public List<PlayerCharacteristic> GetPlayerIds()
        {
            return database.GetAllWithChildren<PlayerCharacteristic>();
        }






        public  List<PlayerCharacteristic> GetPlayerAsync()
        {
            return database.Table<PlayerCharacteristic>().ToList();
        }

       


        public List<Factory> GetFactAsync()
        {
            return database.Table<Factory>().ToList();
        }
        //
        public SQLite.TableQuery<Factory> GetFactoryAsync()
        {
            return database.Table<Factory>();
        }
        //
        public  int SaveFactoryInfoAsync( Factory player)
        {

            return database.Insert(player);
        }
        public int SaveF(List<Factory> player)
        {
            //foreach(var e in player)
            //{
            //    database.Insert(e);
            //}

            return database.Insert(player);
        }




        public int SavePlayerCharAsync(PlayerCharacteristic player)
        {

            return database.Insert(player);
        }
        
        public PlayerCharacteristic GetPlayerCharacById(int id)
        {
            return database.Table<PlayerCharacteristic>().Where(i => i.Id == id).FirstOrDefault();
        }
        public Factory GetFactoryById(int id)
        {
            return database.Table<Factory>().Where(i => i.Id == id).FirstOrDefault();
        }
        public PlayerCharacteristic GetById(int id)
        {
            return database.Table<PlayerCharacteristic>().Where(i => i.PortfolioId == id).FirstOrDefault();
        }


        public List<Factory> ToSource(PlayerCharacteristic player)
        {
           return database.Table<Factory>().Where(i => i.Id == player.PortfolioId).ToList();
        }
        /// Getting
        //public Task<List<PlayerInfo>> GetPlayerAsync()
        //{
        //    return database.Table<PlayerInfo>().ToListAsync();
        //}
        //public Task<List<Factory>> GetFactoryAsync()
        //{
        //    return database.Table<Factory>().ToListAsync();
        //}
        //public Task<List<PlayerCharacteristic>> GetCharacteristicAsync()
        //{
        //    return database.Table<PlayerCharacteristic>().ToListAsync();
        //}
        ///// saving
        //public Task<int> SavePlayerInfoAsync(PlayerInfo player)
        //{
        //    return database.InsertAsync(player);
        //}
        //public Task<int> SaveFactoryInfoAsync(Factory player)
        //{

        //    return database.InsertAsync(player);
        //}



    }
}

