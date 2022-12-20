using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Scanner : ContentPage
    {
        public string qrText; 
        public Scanner()
        {
            InitializeComponent();
        }

        void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scannerText.Text = result.Text + "(type:" +
                 result.BarcodeFormat.ToString();
                qrText = result.Text;
                Open(qrText);
            });
        }
        public async void Open(string code)
        {
            var Code = FindCode(code);
            ServerClass serverClass = APIclass.GetAPI(code);
            string route =  serverClass.data.route;
            string ts = "";

            switch (serverClass.data.ts_type)
            {
                case "bus":
                    ts = "автобус";
                    break;
                case "trolleybus":
                    ts = "троллейбус";
                    break;
                case "tram":
                    ts = "трамвай";
                    break;
            }
           // string desc = serverClass.data.status_Discription;
            DisplayAlert("Поздравляю","Вы вошли в "+ ts +" по маршруту номер " + route ,"OK");            
            await Navigation.PushAsync(new TabPage()); //передаем код ТС
        }
        public string FindCode(string code)
        {
             return code.Substring(20);                ///send the real code
           // return "18-001-1-0005704";
           
        }
    }
}

