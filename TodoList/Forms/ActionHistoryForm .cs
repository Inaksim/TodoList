using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.F
{
    public partial class ActionHistoryForm : Form
    {
        private TaskHistory taskHistory;
        private FileStorageManager fileStorageManager;
        public ActionHistoryForm(TaskHistory history)
        {
            
            InitializeComponent();
            taskHistory = history;
            DisplayActionHistory();


        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void DisplayActionHistory ()
        {
            listBoxActions.ColumnCount = 3;
            listBoxActions.Columns[0].Name = "ActionColumn";
            listBoxActions.Columns[0].HeaderText = "Action";
            listBoxActions.Columns[1].Name = "TitleColumn";
            listBoxActions.Columns[1].Name = "Title";
            listBoxActions.Columns[2].Name = "DateColumn";
            listBoxActions.Columns[2].Name = "Date";



            List<HistoryEntry> actions = new List<HistoryEntry> (taskHistory.getAllActions());
            foreach (HistoryEntry entry in actions)
            {
                listBoxActions.Rows.Add (entry.Type.ToString(), entry.Item.Title, entry.Item.CreationDate);
            }
        }

        private void save_file_Click(object sender, EventArgs e)
        {
            taskHistory.WriteHistoryToFile("history.txt");

        }
    }
}
