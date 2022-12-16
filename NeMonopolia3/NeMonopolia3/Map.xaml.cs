using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.QrCode.Internal;

namespace NeMonopolia3
{
    public partial class Map : ContentPage
    {
        readonly string Code;
        public Location locationTs;
        public Map()
        {
            InitializeComponent();
        }
        public Map(string code)
        {
            InitializeComponent();
            Code = "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/" + code;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
            //     "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/18-002-3-0000526");
            // HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Stream stream = response.GetResponseStream();
            // StreamReader sr = new StreamReader(stream);

            // string sReadData = sr.ReadToEnd();
            // response.Close();

            //// dynamic result = JsonConvert.DeserializeObject<ServerClass>(sReadData);

            // ServerClass result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            // locationTs = new Location();
            // locationTs.Longitude = result.data.longitude;
            // locationTs.Latitude = result.data.latitude;

          // -// pricename.Text = App.DataBase.GetPlayers()[0].Money.ToString();

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
            //    "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/18-001-1-0005705");
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Stream stream = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream);

            //string sReadData = sr.ReadToEnd();
            //response.Close();

            ////dynamic result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            //ServerClass result = JsonConvert.DeserializeObject<ServerClass>(sReadData);

          //-  //var result = APIclass.GetAPI(Code);
            //locationTs = new Location();
            //locationTs.Longitude = result.data.longitude;
            //locationTs.Latitude = result.data.latitude;

        }
        //public bool Comparing()
        //{
           
        //    Thread.Sleep(60000);
        //    var geo = new LocationService();
        //    geo.GetPlayerLocation();
        //    var stop = geo.GetStop();
        //    //locationTs = new Location { Latitude = 46.765, Longitude = -45.645 };
            
        //    if (geo.IsOnStop(geo, stop) && geo.CompareToTs(geo, new LocationService() { Lat = locationTs.Latitude, Lng = locationTs.Longitude }))
        //    {
        //        return true;
        //    }
        //    else
        //    {

        //        return false;
        //    }

        //    ////сделать экран с надписью "Подождите" через пол минуты еще раз сравниить гео и перейти на другую 
        //}
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
           await DisplayAlert("Внимание", "Пожалуйста подождите 1 минуту", "OK");
            var stop = new Stop();
            var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default));
            var geo = new LocationType() {Latitude=result.Latitude, Longitude=result.Longitude };
            DBContext.GetStop(geo,stop);
            if (stop.TItle == null)
            {
                DisplayAlert("Attention", "Вы не на остановке", "OK");
                return;
            }
            else
            {
                Thread.Sleep(30000);
                result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default));
                geo = new LocationType() { Latitude = result.Latitude, Longitude = result.Longitude };
                DBContext.GetStop(geo,stop);
                if (stop.TItle == null)
                    DisplayAlert("Attention", "Вы не на остановке", "OK");
                else
                    await Navigation.PushAsync(new ActionView(stop));
            }
            //if (Comparing())
            //{
            //    await Navigation.PushAsync(new ActionView());
            //}
            //else
            //{
            //    DisplayAlert("Attention", "Вы не на остановке", "OK");
            //}
            //Testing();
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
            //    "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/18-002-3-0000526");
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Stream stream = response.GetResponseStream();
            //StreamReader sr = new StreamReader(stream);

            //string sReadData = sr.ReadToEnd();
            //response.Close();

            ////dynamic result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            //ServerClass result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            //locationTs = new Location();
            //locationTs.Longitude = result.data.longitude;
            //locationTs.Latitude = result.data.latitude;

        }
        public void Testing()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/18-002-3-0000526");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
        }
    }
}

