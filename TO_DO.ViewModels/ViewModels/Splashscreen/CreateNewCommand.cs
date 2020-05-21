using MvvmCross.Navigation;
using System.Threading.Tasks;
using TO_DO.ViewModels.ViewModels.ToDoList;

namespace TO_DO.ViewModels.ViewModels.Splashscreen
{
    public class CreateNewCommand : CommandBaseAsync
    {
        private IMvxNavigationService _navigationService;

        public CreateNewCommand(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public async override Task ExecuteImplementationAsync(object parameter)
        {
            await _navigationService.Navigate<ToDoListViewModel>();
        }
    }
}
