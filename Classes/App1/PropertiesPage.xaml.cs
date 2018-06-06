using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertiesPage : ContentPage
    {
        public PropertiesPage()
        {
            InitializeComponent();
            if (Properties.AppProperties.ContainsKey("btnClickedCount"))
            {
                var keyValue = Properties.AppProperties["btnClickedCount"].ToString();
                lblProperty.Text = keyValue;
            }
        }
    }
}