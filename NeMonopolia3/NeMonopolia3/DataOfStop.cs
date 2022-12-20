using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
	public static class DataOfStop
	{
		public static List<Factory> list = new List<Factory>();
		public static void Loading()
		{
            list = new List<Factory>();
            list.Add(new Factory() {Image="med.jpeg", idFactory = 3, BasePrice = 50000, idStop = 9, Title = "Медицинский центр", Stop = new Stop(), Holds = new List<Hold>(), });
            list.Add(new Factory() {Image="istu.jpeg", idFactory = 4, BasePrice = 30000, idStop = 6, Title = "ИжГТУ им. Калашникова", Stop = new Stop(), Holds = new List<Hold>(), });

            lStops = new List<Stop>();
            lStops.Add(new Stop() { idStop=9, TItle="ул. 30 Лет Победы", Latitude=56.86628115, Longitude=53.18151492, chCommunication=0, chIntellect=0, chHonesty=0, chLuck=0, });
            lStops.Add(new Stop() { idStop=6, TItle = "ИжГТУ им. Калашникова", Latitude = 56.87037265, Longitude = 53.18038106,chIntellect=5,chCommunication=6, chHonesty=0, chLuck=0, });
        }
        public static List<Stop> lStops = new List<Stop>();

    }
}

