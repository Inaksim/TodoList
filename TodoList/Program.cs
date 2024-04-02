using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.F;
using TodoListLibrary;
namespace TodoList
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TaskListForm());
        }
    }
}
