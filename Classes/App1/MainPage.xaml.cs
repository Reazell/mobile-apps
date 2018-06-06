using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            LabelTest.BackgroundColor = Color.DarkBlue;
		}

        public async void btnOk_Clicked(object sender, EventArgs e)
        {
            var text = entryParam.Text;

            if (await DisplayAlert("Czy na pewno?", "Czy na pewno chciales wpisac " + text + " ?" , "Tak", "Nie"))
            {
                await Navigation.PushModalAsync(new SecondPage());
            }
            var button = (Button)sender;
            await DisplayAlert("OK", "Popraw dane", "OK");
        }
	}
}
