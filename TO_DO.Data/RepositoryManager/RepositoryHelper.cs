using Android.Content;
using Android.App;
using System.Collections.Generic;
using TO_DO.Models.Models;
using System;

namespace TO_DO.DataRepository
{
    public static class RepositoryHelper
    {
        public static ISharedPreferences preferences = Application.Context.GetSharedPreferences("ToDoListPreferences", FileCreationMode.Private);

        public static List<ToDoItemModel> ToDoItemModelList = new List<ToDoItemModel>();
        public static ToDoItemModel ToDoItem = new ToDoItemModel();

        public static List<ToDoItemModel> GetItems()
        {
            int numberOfItems = preferences.GetInt("NumberOfItems", 0);

            for (int i = 0; i <= numberOfItems; i++)
            {
                var toDoItem = preferences.GetString(i.ToString(), null);

                if (!string.IsNullOrEmpty(toDoItem))
                {
                    ToDoItem.Title = toDoItem;
                    ToDoItemModelList.Add(ToDoItem);
                }
            }
            return ToDoItemModelList;
        }

        public static void UpdateItems(List<ToDoItemModel> list)
        {
            int itemCount = 0;

            ISharedPreferencesEditor preferencesEditor = preferences.Edit();
            preferencesEditor.Clear();
            preferencesEditor.Commit();

            preferencesEditor = preferences.Edit();
            preferencesEditor.PutInt("NumberOfItems", list.Count);

            foreach (ToDoItemModel item in list)
            {
                preferencesEditor.PutString(itemCount.ToString(), item.Title);
                itemCount++;
            }
            preferencesEditor.Apply();
        }

        public static void UpdateItemCompleted(ToDoItemModel list, int id)
        {
            ISharedPreferencesEditor preferencesEditor = preferences.Edit();
            preferencesEditor.PutString(id.ToString(), list.IsComplete.ToString());
            preferencesEditor.Apply();
        }
    }
}
