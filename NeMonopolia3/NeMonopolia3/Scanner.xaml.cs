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
            DisplayAlert("Поздравляю","Вы вошли в ТС" + route,"OK");            
            await Navigation.PushAsync(new Map(code)); //передаем код ТС
        }
        public string FindCode(string code)
        {
             return code.Substring(20);                ///send the real code
           // return "18-001-1-0005704";
           
        }
    }
}

