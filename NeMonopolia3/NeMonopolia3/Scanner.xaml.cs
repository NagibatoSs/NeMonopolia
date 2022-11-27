using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NeMonopolia3
{
    public partial class Scanner : ContentPage
    {
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
                Open(result.Text);
            });
        }
        public async void Open(string result)
        {
            DisplayAlert("Поздравляю","Вы вошли в ТС","OK");
            var code = FindCode(result);
            await Navigation.PushAsync(new Map(code)); //передаем код ТС
        }
        public string FindCode(string code)
        {
            // return code.Substring(20); ///send the real code
            return "18-002-2-0000331";
           
        }
    }
}

