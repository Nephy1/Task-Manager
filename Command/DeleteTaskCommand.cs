using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using task_app.ViewModel;

namespace task_app.Command
{
    public class DeleteTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        // Trying to take in a specific task and the whole list to remove said task

        //public void Execute(object item1, object item2)
        //{
        //    if (item2 is TaskListViewModel list)
        //    {
        //        // foreach (TaskListViewModel task1 in taskList)
        //         for (int i = 0; i < list.Tasks.Count; i++)
        //        {
        //        TaskViewModel current = list.Tasks[i];
        //        if (current == item1)
        //        {
        //            list.Tasks.Remove(current);
        //        }

        //        }
        //    }
        //}

        // Deletes most recent task
        public void Execute(object parameter)
        {
            if (parameter is TaskListViewModel list)
            {
                list.tasks.RemoveAt(list.Tasks.Count - 1);
            }
        }
    }
}