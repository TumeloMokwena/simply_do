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
using MvvmCross.Droid.Support.V7.AppCompat;

namespace TO_DO
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class Splashscreen : MvxSplashScreenAppCompatActivity
    {
        public Splashscreen()
             : base(Resource.Layout.splash_screen)
        {
        }
    }
}