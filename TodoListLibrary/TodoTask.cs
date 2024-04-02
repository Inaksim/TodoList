using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListLibrary
{
    public class TodoTask : TaskItem
    {
        public DateTime DueData { get; set; }

        public TodoTask(string title, String description, DateTime dueData)
            : base(title, description)
        {
            DueData = dueData;
        }
        public TodoTask()
        {

        }

        public override void MarkAsComplete()
        {
            base.MarkAsComplete();
            Console.WriteLine("Task marked as Complete.");
        }

        public override void MarkAsIncomplete()
        {
            base.MarkAsIncomplete();
            Console.WriteLine("Task marked as incomplete.");
        }




    }
}

