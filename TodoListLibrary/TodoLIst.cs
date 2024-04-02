using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListLibrary
{
    public class TaskList
    {
        public static List<TaskItem> Tasks;

        public TaskList()
        {
            Tasks = new List<TaskItem>();
        }

        public void addTask(TaskItem item)
        {
            Tasks.Add(item);
        }

        public void removeTask(TaskItem item)
        {
            Tasks.Remove(item);
        }

        public List<TaskItem> GetCompletedTasks()
        {
            return Tasks.FindAll(task => task.IsCompleted);
        }

        public List<TaskItem> getIncompleteTasks()
        {
            return Tasks.FindAll(task => !task.IsCompleted);
        }

        public delegate void TaskCompletedEventHandler(TaskItem item);

        public List<TaskItem> getAll()
        {
            return new List<TaskItem>(Tasks);
        }

        public TaskItem getTaskAtIndex(int index)
        {
            return Tasks[index];
        }
        public void removeTaskAtIndex(int index)
        {
            Tasks.RemoveAt(index);
        }

        public void removeItem(TaskItem item)
        {
            Tasks.Remove(item);
        }
        public static void UpdateTask(int index, TaskItem updatedTask)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks[index] = updatedTask;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        public int IndexOfTaskByTitle(string title)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"Comparing {Tasks[i].Title} with {title}");

                if (Tasks[i].Title == title)
                {
                    Console.WriteLine($"Match found at index {i}");
                    return i;
                }
            }
            Console.WriteLine("No match found");
            return -1;
        }

    }
}
