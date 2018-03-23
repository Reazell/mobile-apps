using Android.App;
using Android.Widget;
using Android.OS;

namespace _9GAG
{
    [Activity(Label = "_9GAG", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

