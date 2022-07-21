using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Health.ViewModels
{
    class ToDoListViewModel
    {
        public ICommand AddTasksCommand => new Command(AddTask);
        public ICommand RemoveTasksCommand => new Command(RemoveTask);
        public ICommand EditTasksCommand => new Command(EditTask);
        public ObservableCollection<string> TasksToDo { get; set; }
        public string TasksToAdd { get; set; }

        public string SelectedTask { get; set; }

        public void AddTask()
        {
            TasksToDo.Add(TasksToAdd);
        }

        public void RemoveTask()
        {
            TasksToDo.Remove(SelectedTask);
        }

        public void EditTask()
        {
            int newIndex = TasksToDo.IndexOf(SelectedTask);
            TasksToDo.Remove(SelectedTask);

            TasksToDo.Add(TasksToAdd);
            int oldIndex = TasksToDo.IndexOf(TasksToAdd);
            
            TasksToDo.Move(oldIndex, newIndex);
        }
        public ToDoListViewModel()
        {
            TasksToDo = new ObservableCollection<string>
            {
            };
        }
    }
}