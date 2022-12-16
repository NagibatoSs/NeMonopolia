using System;
using Xamarin.Essentials;

namespace NeMonopolia3
{
	public class LocationService
	{
		public static double Lat;
		public static  double Lng;
		public LocationService()
		{
		}
		public static async void GetPlayerLocation()
		{
			var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default));
			Lat = result.Latitude;
			Lng = result.Longitude;
        }
		//public static bool IsOnStop(LocationService player, LocationService stop)
		//{
		//	Location playerLoc = new Location(player.Lat, player.Lng);
		//	Location StopLoc = new Location(stop.Lat, stop.Lng);
		//	double miles = Location.CalculateDistance(playerLoc, StopLoc, DistanceUnits.Kilometers);
		//	//if (miles > 1) return false; else return true;
		//	return true;
  //      }
		//public LocationService GetStop()
		//{
		//	var stop = new LocationService()
		//	{
		//		Lat = 48.87898,
		//		Lng = -51.8999
		//	};
		//	return stop;
		//}
		public bool CompareToTs(Location player, Location TS)
		{
			Location playerLoc = new Location(player.Latitude, player.Longitude);
			Location TsLoc = new Location(TS.Latitude, TS.Longitude);
			double miles = Location.CalculateDistance(playerLoc, TsLoc, DistanceUnits.Kilometers);
			//if (miles > 1) return false; else return true;
			return true;
        }
	}
}

