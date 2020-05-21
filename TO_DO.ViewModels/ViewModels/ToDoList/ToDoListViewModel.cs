using MvvmCross.ViewModels;
using System.Collections.Generic;
using TO_DO.DataRepository;
using TO_DO.Models.Models;

namespace TO_DO.ViewModels.ViewModels.ToDoList
{
    public class ToDoListViewModel : MvxViewModel
    {
        public int PercentageCompleted
        {
            get => _percentageCompleted;
            set => SetProperty(ref value, _percentageCompleted);
        }
        public int _percentageCompleted;

        public List<ToDoItemModel> ToDoList { get; set; }

        public ToDoListViewModel()
        {
            GetToDoList();
        }

        public int GetPercentage(List<ToDoItemModel> toDoList)
        {
            int totalItems = toDoList.Count;
            int itemsCompleted = 0;
            int percentage = 0;

            foreach(ToDoItemModel item in toDoList)
            {
                if(item.IsComplete)
                {
                    itemsCompleted++;
                }
            }

            percentage = (itemsCompleted / totalItems) * 100;

            return PercentageCompleted;
        }

        public List<ToDoItemModel> GetToDoList()
        {
            ToDoList = RepositoryHelper.GetItems();
            PercentageCompleted = GetPercentage(ToDoList);
            return ToDoList;
        }

        public void UpdateItems(List<ToDoItemModel> list)
        {
            RepositoryHelper.UpdateItems(list);
            ToDoList = GetToDoList();
        }
    }
}
