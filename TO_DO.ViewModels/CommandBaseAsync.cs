using System.Threading.Tasks;

namespace TO_DO.ViewModels
{
    public abstract class CommandBaseAsync : CommandBase
    {
        public CommandBaseAsync(string label = "") : base(label)
        { }

        public override async void Execute(object parameter)
        {
            await ExecuteImplementationAsync(parameter);
        }

        public abstract Task ExecuteImplementationAsync(object parameter);
    }
}
