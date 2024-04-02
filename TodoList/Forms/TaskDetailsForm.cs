using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListLibrary;
namespace TodoList.F
{
    public partial class TaskDetailsForm : Form
    {
        private TaskItem selectedTask;
        private TaskList taskList;
        private TodoTask todoTask = new TodoTask();
        private int Iindex;

        public TaskDetailsForm(TaskItem task, TaskList list, int index)
        {
            InitializeComponent();
            selectedTask = task;
            taskList = list;
            Iindex = index;

            txtTitle.Text = selectedTask.Title;
            txtDescr.Text = selectedTask.Description;
            checkBox1.Checked = selectedTask.IsCompleted;
            if(selectedTask.IsCompleted == true)
            {
                todoTask.MarkAsComplete();
            } else
            {
                todoTask.MarkAsIncomplete();
            }
        }

        

        private void Btn_cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private  void btn_save_Click(object sender, EventArgs e)
        {
            selectedTask.SetTitle(txtTitle.Text);
            selectedTask.SetDescription(txtDescr.Text);
            selectedTask.IsCompleted = checkBox1.Checked;
            selectedTask.CreationDate = DateTime.Now;
            
            
            if (Iindex != -1)
            {
                TaskList.UpdateTask(Iindex, selectedTask);
                this.Close();

            }
            else { MessageBox.Show("Task not found"); }

            DialogResult = DialogResult.OK;
            Close();

        }
    }


}
