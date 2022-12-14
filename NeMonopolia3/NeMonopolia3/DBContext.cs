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

namespace NeMonopolia3
{
	public class DBContext
	{
		public DBContext()
		{
		}
        public static async void SetPlayers(PlayerInfo player)
        {
            
            string JSONData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(player));
            WebRequest request = WebRequest.Create("http://nemonopolia.somee.com/Home/PlayerInfoEdit");
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
            
            CurrentPlayerData.CurPlayerInfo.Name = helloStr;
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

