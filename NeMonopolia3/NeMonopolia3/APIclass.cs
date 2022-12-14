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
	public class APIclass
	{
        public static ServerClass GetAPI(string code)
        {
            string Code = "https://testapi.igis-transport.ru/game-wMdF23UUDp0iasAK/ts/" + code;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Code);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            //dynamic result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            ServerClass result = JsonConvert.DeserializeObject<ServerClass>(sReadData);
            return result;
        }
    }
       
    
}

