using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
	public class DataLoading
	{
		public DataLoading()
		{
		}
		public static void Deleting()
		{

		}
		public static void PlayerAdd()
		{
			App.DataBase.SaveChildrens(new List<PlayerCharacteristic>
			{
			     new PlayerCharacteristic
				 {
					Id=1,
					Money=550100,
					Intellect=75,
					Honesty=67,
					Communication=45,
					Luck=20,
					IsPlaying=true,
					StopCount=3,
					Portfolio = new List<FactoryInf>()
				 }

			});

		}
		public static void FactoryAdd()
		{
			App.DataBase.SaveChildrens(new List<FactoryInf>
			{
				new FactoryInf {
					Name ="KFC",
					Price=50000,
					Rent =10000,
					Image= "KFC.jpg",
					Security= 20,
					OwnerId=0,
                    ChangerIntellect =10,
                    ChangerHonesty=0,
                    ChangerCommunication =5,
                    ChangerLuck =15

                },
				new FactoryInf
				{
					Name ="ДАТАБАНК",
					Price=900000,
					Rent =20000,
					Image= "Bank.jpg",
					Security= 70,
					OwnerId=0,
                    ChangerIntellect =0,
                    ChangerHonesty=10,
                    ChangerCommunication =15,
                    ChangerLuck =2
                },
				new FactoryInf
				{
					Name ="Аксион",
					Price=750000,
					Rent =50000,
					Image= "Aksion.jpg",
					Security= 65,
					OwnerId=0,
                    ChangerIntellect =1,
                    ChangerHonesty=0,
                    ChangerCommunication =10,
                    ChangerLuck =4
                },

			});
		}
	}
}

