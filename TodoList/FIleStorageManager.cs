using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public class FileStorageManager
    {

        public void WriteHistoryToFile(string filePath, List<HistoryEntry> allActions)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    

                    foreach (var entry in allActions)
                    {
                        writer.WriteLine($"Action: {entry.Type}, Task: {entry.Item.Title}, CreationTime: {entry.Item.CreationDate}");
                    }
                }
                MessageBox.Show("History written to file succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing history to file: {ex.Message}");

            }
        }
    }
}
