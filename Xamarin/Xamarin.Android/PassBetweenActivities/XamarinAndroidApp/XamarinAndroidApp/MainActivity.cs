using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinAndroidApp
{
    [Activity(Label = "XamarinAndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        View v;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.button1); //https://forums.xamarin.com/discussion/15115/how-to-set-button-onclick-event-handler-declaratively
            button.Click += delegate { PassToSecondary(v); }; //https://developer.xamarin.com/recipes/android/fundamentals/activity/start_an_activity/
        }

        public void PassToSecondary(View view) 
        {
            StartActivity(typeof(SecondaryActivity));
        }
    }
}

