using MvvmCross.IoC;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TO_DO.ViewModels.ViewModels.SplashScreen;

namespace TO_DO.ViewModels
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterCustomAppStart<CustomAppStart<ExtendedSplashScreenViewModel>>();
        }
    }

    public class CustomAppStart<TViewModel> : MvxAppStart<TViewModel>
        where TViewModel : IMvxViewModel
    {
        public CustomAppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override void NavigateToFirstViewModel(object hint)
        {
            NavigationService.Navigate<TViewModel>();
        }
    }
}
