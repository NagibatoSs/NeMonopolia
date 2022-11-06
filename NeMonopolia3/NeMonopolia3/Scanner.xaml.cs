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
            });
        }
    }
}

