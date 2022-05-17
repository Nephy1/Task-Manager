using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using task_app.Command;

namespace task_app.ViewModel
{
    public class TaskListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TaskViewModel> tasks = new ObservableCollection<TaskViewModel>();
        public ObservableCollection<TaskViewModel> Tasks
        {
            get { return tasks; }
            set {
                if (tasks != value)
                {
                    tasks = value;
                    NotifyPropertyChanged(nameof(Tasks));
                }
              }
        }
        public string TaskName { get; set; }


        // Declaring Commands to create and delete tasks
        public ICommand CreateTaskCommand { get { return new CreateTaskCommand(); } }
        public ICommand DeleteTaskCommand { get { return new DeleteTaskCommand(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
