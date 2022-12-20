using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Xamarin.Essentials;
using System.Collections.Specialized;

namespace NeMonopolia3
{
	public class DBContext
	{
		public DBContext()
		{
		}
        
        public static async void SetPlayers(Player player)
        {
            //try
            //{
                string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player));
                //System.Net.ServicePointManager.Expect100Continue = false;
                //  System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/SavePlayer");
                request.Method = "POST";
                string query = $"player={JSONData}";
                byte[] byteMsg = Encoding.UTF8.GetBytes(query);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteMsg.Length;

                using (Stream stream = await request.GetRequestStreamAsync())
                {
                    await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
                }

                WebResponse response = await request.GetResponseAsync();
                string answer = null;
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader sR = new StreamReader(s))
                    {
                        answer = await sR.ReadToEndAsync();
                    }
                }
                response.Close();
            //}
            //catch(Exception e)
            //{
            //    var error = e.ToString();
            //}
        }

        public static async void SetPlayersByParams(Player player)
        {
            //try
            //{
            string JSONName = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player.UserName));
            string JSONLogin = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player.Login));
            string JSONPassword = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player.Password));
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

            queryString.Add("name", $"{JSONName}");
            queryString.Add("login", $"{JSONLogin}");
            queryString.Add("password", $"{JSONPassword}");


            //System.Net.ServicePointManager.Expect100Continue = false;
            //  System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/SavePlayerByParams");
            request.Method = "POST";
            //string query = $"player={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(queryString.ToString());
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();
            //}
            //catch(Exception e)
            //{
            //    var error = e.ToString();
            //}
        }


        public static async void SetPlayer(PlayerInfo player)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/SavePlayerInfo");
            request.Method = "POST";
            string query = $"playerInfo={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

           
            // // string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player));
            // string JSONData = await Task.Run(() => JsonConvert.SerializeObject(player));
            // // string JSONData = JsonSerializer.Serialize<PlayerInfo>(player);
            // WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/PlayerInfoEdit");
            // request.Method = "POST";
            // string query = $"playerInfo={JSONData}";
            // byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            // request.ContentType = "application/x-www-form-urlencoded";
            // request.ContentLength = byteMsg.Length;

            // using (Stream stream = await request.GetRequestStreamAsync())
            // {
            //     await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            // }

            // WebResponse response = await request.GetResponseAsync();
            // string answer = null;
            // using (Stream s = response.GetResponseStream())
            // {
            //     using (StreamReader sR = new StreamReader(s))
            //     {
            //         answer = await sR.ReadToEndAsync();
            //     }
            // }
            // response.Close();

            //// CurrentPlayerData.CurPlayerInfo = player;

        }
        public async static void GetHello()
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject("Hi"));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/Hello");
            request.Method = "POST";
            string query = $"name={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            string helloStr = JsonConvert.DeserializeObject<string>(answer);
            // MessageBox.Show(helloStr);
            //CurrentPlayerData.CurPlayerInfo.Name = helloStr;
        }
        public static async void GetPlayerName(int id)
		{
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPlayerNameById");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            string helloStr = JsonConvert.DeserializeObject<string>(answer);
            //string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id.ToString()));
            //WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPlayerInfo");
            //request.Method = "POST";
            //string query = $"id={JSONData}";
            //byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = byteMsg.Length;

            //using (Stream stream = await request.GetRequestStreamAsync())
            //{
            //    await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            //}

            //WebResponse response = await request.GetResponseAsync();
            //string answer = null;
            //using (Stream s = response.GetResponseStream())
            //{
            //    using (StreamReader sR = new StreamReader(s))
            //    {
            //        answer = await sR.ReadToEndAsync();
            //    }
            //}
            //response.Close();

            //string  helloStr = JsonConvert.DeserializeObject<string>(answer);
            //// MessageBox.Show(helloStr);
            
            CurrentPlayerData.CurPlayer.UserName = helloStr;
        }
        public static async void GetPlayer(int id)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPlayerById1");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Player helloStr = JsonConvert.DeserializeObject<Player>(answer);
            
            CurrentPlayerData.CurPlayer = helloStr;
        }

        public static async void GetPersById(int id)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPersById");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Player helloStr = JsonConvert.DeserializeObject<Player>(answer);

            
        }
        public static async Task<Pers> GetPersonById(int id)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPersById");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Pers helloStr = JsonConvert.DeserializeObject<Pers>(answer);

            return helloStr;
        }

        public static async void GetStop(LocationType location, Stop stop)
        {
            //Location location = new() { Latitude = latitude, Longitude = longtitude }; 
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(location));
            var a = 0;
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetStopByLocationOfPlayer");
            request.Method = "POST";
            string query = $"location={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            stop = JsonConvert.DeserializeObject<Stop>(answer);
            CurrentPlayerData.CurStop = stop;
        }

        public static  async void GetStopById(int id)
        {
            //Location location = new() { Latitude = latitude, Longitude = longtitude }; 
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            var a = 0;
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetStopById");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Stop stop = JsonConvert.DeserializeObject<Stop>(answer);
            CurrentPlayerData.CurStop = stop;
            
        }

        public static async void GetFactory(int id)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            var a = 0;
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetFactoryByStopId");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Factory factory = JsonConvert.DeserializeObject<Factory>(answer);
            CurrentPlayerData.CurStop.factory = new List<Factory>();
            CurrentPlayerData.CurStop.factory.Add(factory);
            //CurrentPlayerData.CurStop.factory[0] = factory;
        }

        public static async void GetGameById(int id)
        {
            //Location location = new() { Latitude = latitude, Longitude = longtitude }; 
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(id));
            var a = 0;
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetGameById");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            Game game = new Game();

            game = JsonConvert.DeserializeObject<Game>(answer);
            CurrentPlayerData.CurGame = game;
        }


        public static async void IsAuthorizedPerson(PlayerInfo player)
        {
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/GetPlayerInfo");
            request.Method = "POST";
            string query = $"id={JSONData}";
            byte[] byteMsg = Encoding.UTF8.GetBytes(query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteMsg.Length;

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMsg, 0, byteMsg.Length);
            }

            WebResponse response = await request.GetResponseAsync();
            string answer = null;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            response.Close();

            bool isAuthorized = JsonConvert.DeserializeObject<bool>(answer);
            // MessageBox.Show(helloStr);
           // CurrentPlayerData.CurPlayerInfo.Name = helloStr;
        }


    }
}

