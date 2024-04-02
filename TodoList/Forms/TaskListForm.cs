using System;
using System.Linq;
using System.Windows.Forms;
using TodoListLibrary;

namespace TodoList.F
{
    public partial class TaskListForm : Form
    {
        private TaskList taskList = new TaskList();
        private TaskHistory taskHistory;

        public TaskListForm()
        {
            InitializeComponent();
            taskList = new TaskList();
            FileStorageManager fileStorageManager = new FileStorageManager();
            taskHistory = new TaskHistory(fileStorageManager);
            DisplayTasks();

        }

        private void InitializeDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "TitleColumn";
            dataGridView1.Columns[0].HeaderText = "Title";

            dataGridView1.Columns[1].Name = "DescriptionColumn";
            dataGridView1.Columns[1].HeaderText = "Description";

            dataGridView1.Columns[2].Name = "CompletedColumn";
            dataGridView1.Columns[2].HeaderText = "Completed";

            dataGridView1.Columns[3].HeaderText = "DateColumn";
            dataGridView1.Columns[3].HeaderText = "Date";


        }

        private void DisplayTasks()
        {
            InitializeDataGridView();
            foreach (TaskItem item in taskList.getAll())
            {
                dataGridView1.Rows.Add(item.Title, item.Description, item.IsCompleted, item.CreationDate);
            }
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem newTask = new TaskItem(task_title.Text, task_description.Text);
            taskList.addTask(newTask);

            taskHistory.AddAction(ActionType.Add, newTask);
            DisplayTasks();

        }

        private void btnEditTask_click(object sender, EventArgs e)
        {

            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if(selectedIndex < 0) MessageBox.Show("Select task");
            
            TaskItem item = taskList.getTaskAtIndex(selectedIndex);
            TaskDetailsForm taskDetailsForm = new TaskDetailsForm(item, taskList, selectedIndex);
            taskDetailsForm.ShowDialog();

            taskHistory.AddAction(ActionType.Update, item);
            
            DisplayTasks();

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if(selectedIndex < 0) MessageBox.Show("Select task");

            TaskItem deleted = taskList.getTaskAtIndex(selectedIndex);
            taskList.removeTask(deleted);

            taskHistory.AddAction(ActionType.Delete, deleted);
            
            DisplayTasks();


        }


        private void undo_btn_Click(object sender, EventArgs e)
        {
            taskHistory.Undo(taskList);
            DisplayTasks();


        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            taskHistory.Redo(taskList);
            DisplayTasks();

        }

        private void showHistory_btn_Click(object sender, EventArgs e)
        {
            ActionHistoryForm actionHistoryForm = new ActionHistoryForm(taskHistory);
            actionHistoryForm.ShowDialog();
        }

        private void filtr_by_name_Click(object sender, EventArgs e)
        {
            
            InitializeDataGridView();
            var sortedList = TaskList.Tasks.OrderBy(task => task.Title).ToList();
            foreach (TaskItem item in sortedList)
            {
                dataGridView1.Rows.Add(item.Title, item.Description, item.IsCompleted, item.CreationDate);
            }

        }

        private void filtr_by_date_Click(object sender, EventArgs e)
        {
            
            InitializeDataGridView();
            DateTime date = DateTime.Now;
            var sortedList = TaskList.Tasks.OrderBy(task => task.CreationDate).ToList();
            foreach (TaskItem item in sortedList)
            {
                dataGridView1.Rows.Add(item.Title, item.Description, item.IsCompleted, item.CreationDate);
            }

        }

        private void filtr_by_status_Click(object sender, EventArgs e)
        {
            
            InitializeDataGridView();
            var sortedList = TaskList.Tasks.Where(task => task.IsCompleted == true).ToList();
            foreach (TaskItem item in sortedList)
            {
                dataGridView1.Rows.Add(item.Title, item.Description, item.IsCompleted, item.CreationDate);
            }

        }

        private void filtr_by_length_Click(object sender, EventArgs e)
        {
            
            InitializeDataGridView();
            var sortedList = TaskList.Tasks.OrderBy(task => task.Description.Length);
            foreach (TaskItem item in sortedList)
            {
                dataGridView1.Rows.Add(item.Title, item.Description, item.IsCompleted, item.CreationDate);
            }

        }

       
    }
}
