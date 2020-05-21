using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using TO_DO.ViewModels.ViewModels.SplashScreen;

namespace TO_DO.Views
{
    [Activity(Theme = "@style/AppTheme.NoActionBar")]
    public class ExtendedSplashscreenView : MvxAppCompatActivity<ExtendedSplashScreenViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.menu_screen);
            Button createNewButton = FindViewById<Button>(Resource.Id.newToDoNavButton);

            createNewButton.Click += async delegate
            {
                ViewModel.CreateCommand.Execute(null);
            };
        }
    }
}