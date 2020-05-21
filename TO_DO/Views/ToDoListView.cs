using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Binding.Views;
using TO_DO.Models.Models;
using TO_DO.ViewModels.ViewModels.ToDoList;

namespace TO_DO.Views
{
    [Activity(Label = "@string/actionbar_title_TDL", 
              Theme = "@style/Theme.AppCompat.Light.DarkActionBar",
              WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class ToDoListView : MvxAppCompatActivity<ToDoListViewModel>
    {
        private ToDoItemModel _toDoItem = new ToDoItemModel();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.todo_list);

            ToDoListViewModel vm = new ToDoListViewModel();

            TextView HeaderText = (TextView)FindViewById(Resource.Id.headerText);
            HeaderText.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;

            TextView progressStatus = (TextView)FindViewById(Resource.Id.progressStatus);
            progressStatus.Text = vm.PercentageCompleted +"% Done";

            ProgressBar progressBar = (ProgressBar)FindViewById(Resource.Id.progressBar);

            TextView ToDoSubheaderText = (TextView)FindViewById(Resource.Id.todoSubHeader);

            EditText toDoItemText = (EditText)FindViewById(Resource.Id.toDoItemText);

            MvxListView listView = (MvxListView)FindViewById(Resource.Id.toDoListView);
            this.CreateBinding(listView)
                .For(bind => bind.ItemsSource)
                .To<ToDoListViewModel>(bind => bind.ToDoList)
                .Apply();
            
            Button addButton = (Button)FindViewById(Resource.Id.AddButton);

            addButton.Click += async delegate
            {
                if (!string.IsNullOrEmpty(toDoItemText.Text))
                {
                    _toDoItem.Title = toDoItemText.Text;

                    vm.ToDoList.Add(_toDoItem);

                    toDoItemText.Text = "";

                    vm.UpdateItems(vm.ToDoList);
                }
                else
                {
                    Toast.MakeText(this, "Cannot create empty To Do item", ToastLength.Short);
                }
            };
        }
    }
}