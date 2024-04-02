using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListLibrary;
namespace TodoList
{
    [Serializable]
    public class HistoryEntry
    {
        public ActionType Type { get; set; }
        public TaskItem Item { get; set; }

    }
}
