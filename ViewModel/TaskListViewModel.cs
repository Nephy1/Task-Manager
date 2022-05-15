using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_app.ViewModel
{
    public class TaskListViewModel
    {
        public List<TaskViewModel> Tasks { get; set; }
        public string TaskName { get; set; }
    }
}
