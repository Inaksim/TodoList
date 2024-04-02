using System;
using System.Collections.Generic;
using TodoListLibrary;

namespace TodoList
{
    [Serializable]
    public class TaskHistory
    {
        private Stack<HistoryEntry> undoStack;
        private Stack<HistoryEntry> redoStack;
        
        private FileStorageManager storageManager;

       public TaskHistory(FileStorageManager fileStorageManager) 
        {
            undoStack = new Stack<HistoryEntry>();
            redoStack = new Stack<HistoryEntry>();
            storageManager = fileStorageManager;
        }

        public void AddAction(ActionType action, TaskItem item)
        {
            undoStack.Push(new HistoryEntry { Type = action, Item = item });
            redoStack.Clear();
        }

        public HistoryEntry Add_Undo ()
        {
            if(undoStack.Count > 0 )
            {
                HistoryEntry entry = undoStack.Pop();
                redoStack.Push(entry);
                return entry;
            }
            return null;
        }

        public HistoryEntry Add_Redo ()
        {
            if(redoStack.Count > 0 ) 
            {
                HistoryEntry entry = redoStack.Pop();
                undoStack.Push(entry);
                return entry;
            }
            return null;
        }

        public void Undo(TaskList list)
        {
            HistoryEntry entry = Add_Undo();
            if(entry != null)
            {
                switch(entry.Type) 
                {
                    case ActionType.Add: list.removeItem(entry.Item);
                        break;
                    case ActionType.Delete: list.addTask(entry.Item);
                        break;
                    case ActionType.Update: 
                        TaskItem orgTask = Add_Undo().Item;
                        if(orgTask != null)
                        {
                            int index = list.IndexOfTaskByTitle(orgTask.Title);
                            if (index != -1) TaskList.UpdateTask(index, orgTask);
                        }
                        break;
                   
                }
            }
        }

        public void Redo(TaskList list)
        {
            HistoryEntry entry = Add_Redo();
            if(entry!=null)
            {
                switch(entry.Type)
                {
                    case ActionType.Add: list.addTask(entry.Item); 
                        break;
                    case ActionType.Delete: list.removeTask(entry.Item);
                        break;
                    case ActionType.Update:
                        TaskItem orgTask = Add_Redo().Item;
                        if (orgTask != null)
                        {
                            int index = list.IndexOfTaskByTitle(orgTask.Title);
                            if (index != -1) TaskList.UpdateTask(index, orgTask);
                        }
                        break;
                }
            }
        }

        public List<HistoryEntry> getAllActions() 
        { 
             List<HistoryEntry> allActions = new List<HistoryEntry>();
            allActions.AddRange(undoStack);
            allActions.AddRange(redoStack);
            return allActions;
        }

        public void WriteHistoryToFile(string filePath)
        {
            List<HistoryEntry> allActions = getAllActions();

            storageManager.WriteHistoryToFile(filePath, allActions);
        }

    }
}