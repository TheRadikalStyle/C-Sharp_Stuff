using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinAndroidApp
{
    [Activity(Label = "SecondaryActivity", Icon = "@drawable/icon")]
    public class SecondaryActivity : Activity
    {
        View v;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Secondary);

            Button button = FindViewById<Button>(Resource.Id.button2); 
            button.Click += delegate { PassToSecondary(v); }; 
            // Create your application here
        }
    }
}