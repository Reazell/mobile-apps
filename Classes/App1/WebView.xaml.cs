using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebView : ContentPage
    {
        private string _url;

        public WebView(string url)
        {
            InitializeComponent();
            _url = url;
            webView.Source = _url;
        }
    }
}