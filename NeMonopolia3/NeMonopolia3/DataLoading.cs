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
					Portfolio = new List<Factory>()
				 }

			});

		}
		public static void FactoryAdd()
		{
			App.DataBase.SaveChildrens(new List<Factory>
			{
				new Factory {
					Name ="KFC",
					Price=50000,
					rent =10000,
					Image= "KFC.jpg",
					security= 20,
					OwnerId=0,
                    changerIntellect =10,
                    changerHonesty=0,
                    changerCommunication =5,
                    changerLuck =15

                },
				new Factory
				{
					Name ="ДАТАБАНК",
					Price=900000,
					rent =20000,
					Image= "Bank.jpg",
					security= 70,
					OwnerId=0,
                    changerIntellect =0,
                    changerHonesty=10,
                    changerCommunication =15,
                    changerLuck =2
                },
				new Factory
				{
					Name ="Аксион",
					Price=750000,
					rent =50000,
					Image= "Aksion.jpg",
					security= 65,
					OwnerId=0,
                    changerIntellect =1,
                    changerHonesty=0,
                    changerCommunication =10,
                    changerLuck =4
                },

			});
		}
	}
}

