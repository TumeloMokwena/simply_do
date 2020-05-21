using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TO_DO.ViewModels.ViewModels.Splashscreen;

namespace TO_DO.ViewModels.ViewModels.SplashScreen
{
    public class ExtendedSplashScreenViewModel : MvxViewModel
    {
        public CreateNewCommand CreateCommand { get; }

        public ExtendedSplashScreenViewModel(IMvxNavigationService navigationService)
        {
            CreateCommand = new CreateNewCommand(navigationService);
        }
    }
}
