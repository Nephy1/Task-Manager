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
            // Run Date Function
            MainWindow_Load();
            var tasks = new TaskListViewModel();
            this.DataContext = tasks;

        }
        private void MainWindow_Load()
            // DATE SETUP
        {
            var date = DateTime.UtcNow.ToLongDateString();
            dateLabel.Content = date;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
