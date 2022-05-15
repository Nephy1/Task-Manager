using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using task_app.ViewModel;

namespace task_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var tasks = new TaskListViewModel();
            tasks.Tasks = new List<TaskViewModel>(); 
            tasks.Tasks.Add(new TaskViewModel() { Name = "Task 1", Complete = false });
            tasks.Tasks.Add(new TaskViewModel() { Name = "Task 2", Complete = true });
            this.DataContext = tasks;

        }
    }
}
