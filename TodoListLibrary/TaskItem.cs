using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListLibrary
{
    public class TaskItem
    {
        public String Title { get; private set; }
        public String Description { get; private set; }
        public bool IsCompleted { get; set; }

        public DateTime CreationDate { get; set; }

        public TaskItem(String title, String description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
            CreationDate = DateTime.Now;
        }

        public TaskItem() { }

        public void SetTitle(String newTitle)
        {
            Title = newTitle;
        }
        public void SetDescription(String newDescription)
        {
            Description = newDescription;
        }

        public virtual void MarkAsComplete()
        {
            IsCompleted = true;
        }

        public virtual void MarkAsIncomplete()
        {
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Title} - {Description} ({(IsCompleted ? "Completed" : "Incomplete")})";
        }
    }
}
