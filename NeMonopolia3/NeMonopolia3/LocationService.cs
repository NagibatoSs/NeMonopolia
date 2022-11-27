using System;
using Xamarin.Essentials;

namespace NeMonopolia3
{
	public class LocationService
	{
		public double Lat;
		public double Lng;
		public LocationService()
		{
		}
		public async void GetPlayerLocation()
		{
			var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default));
			Lat = result.Latitude;
			Lng = result.Longitude;
        }
		public bool IsOnStop(LocationService player, LocationService stop)
		{
			Location playerLoc = new Location(player.Lat, player.Lng);
			Location StopLoc = new Location(stop.Lat, stop.Lng);
			double miles = Location.CalculateDistance(playerLoc, StopLoc, DistanceUnits.Kilometers);
			//if (miles > 1) return false; else return true;
			return true;
        }
		public LocationService GetStop()
		{
			var stop = new LocationService()
			{
				Lat = 48.87898,
				Lng = -51.8999
			};
			return stop;
		}
		public bool CompareToTs(LocationService player, LocationService TS)
		{
			Location playerLoc = new Location(player.Lat, player.Lng);
			Location TsLoc = new Location(TS.Lat, TS.Lng);
			double miles = Location.CalculateDistance(playerLoc, TsLoc, DistanceUnits.Kilometers);
			//if (miles > 1) return false; else return true;
			return true;
        }
	}
}

