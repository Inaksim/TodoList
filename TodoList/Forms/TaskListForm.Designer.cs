namespace TodoList.F
{
    partial class TaskListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.task_title = new System.Windows.Forms.TextBox();
            this.task_description = new System.Windows.Forms.TextBox();
            this.create_task_bttn = new System.Windows.Forms.Button();
            this.edit_task_bttn = new System.Windows.Forms.Button();
            this.delete_task_btnn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.undo_btn = new System.Windows.Forms.Button();
            this.redo_btn = new System.Windows.Forms.Button();
            this.showHistory_btn = new System.Windows.Forms.Button();
            this.filtr_by_name = new System.Windows.Forms.Button();
            this.filtr_by_date = new System.Windows.Forms.Button();
            this.filtr_by_status = new System.Windows.Forms.Button();
            this.filtr_by_length = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // task_title
            // 
            this.task_title.Location = new System.Drawing.Point(13, 47);
            this.task_title.Name = "task_title";
            this.task_title.Size = new System.Drawing.Size(100, 20);
            this.task_title.TabIndex = 0;
            // 
            // task_description
            // 
            this.task_description.Location = new System.Drawing.Point(12, 73);
            this.task_description.Name = "task_description";
            this.task_description.Size = new System.Drawing.Size(100, 20);
            this.task_description.TabIndex = 1;
            // 
            // create_task_bttn
            // 
            this.create_task_bttn.Location = new System.Drawing.Point(157, 47);
            this.create_task_bttn.Name = "create_task_bttn";
            this.create_task_bttn.Size = new System.Drawing.Size(75, 23);
            this.create_task_bttn.TabIndex = 2;
            this.create_task_bttn.Text = "Create";
            this.create_task_bttn.UseVisualStyleBackColor = true;
            this.create_task_bttn.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // edit_task_bttn
            // 
            this.edit_task_bttn.Location = new System.Drawing.Point(255, 47);
            this.edit_task_bttn.Name = "edit_task_bttn";
            this.edit_task_bttn.Size = new System.Drawing.Size(75, 23);
            this.edit_task_bttn.TabIndex = 3;
            this.edit_task_bttn.Text = "Edit";
            this.edit_task_bttn.UseVisualStyleBackColor = true;
            this.edit_task_bttn.Click += new System.EventHandler(this.btnEditTask_click);
            // 
            // delete_task_btnn
            // 
            this.delete_task_btnn.Location = new System.Drawing.Point(353, 47);
            this.delete_task_btnn.Name = "delete_task_btnn";
            this.delete_task_btnn.Size = new System.Drawing.Size(75, 23);
            this.delete_task_btnn.TabIndex = 4;
            this.delete_task_btnn.Text = "Delete";
            this.delete_task_btnn.UseVisualStyleBackColor = true;
            this.delete_task_btnn.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-33, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 256);
            this.dataGridView1.TabIndex = 5;
            // 
            // undo_btn
            // 
            this.undo_btn.Location = new System.Drawing.Point(178, 108);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(75, 23);
            this.undo_btn.TabIndex = 6;
            this.undo_btn.Text = "Undo";
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // redo_btn
            // 
            this.redo_btn.Location = new System.Drawing.Point(276, 108);
            this.redo_btn.Name = "redo_btn";
            this.redo_btn.Size = new System.Drawing.Size(75, 23);
            this.redo_btn.TabIndex = 7;
            this.redo_btn.Text = "Redo";
            this.redo_btn.UseVisualStyleBackColor = true;
            this.redo_btn.Click += new System.EventHandler(this.redo_btn_Click);
            // 
            // showHistory_btn
            // 
            this.showHistory_btn.Location = new System.Drawing.Point(566, 46);
            this.showHistory_btn.Name = "showHistory_btn";
            this.showHistory_btn.Size = new System.Drawing.Size(91, 23);
            this.showHistory_btn.TabIndex = 8;
            this.showHistory_btn.Text = "Show History";
            this.showHistory_btn.UseVisualStyleBackColor = true;
            this.showHistory_btn.Click += new System.EventHandler(this.showHistory_btn_Click);
            // 
            // filtr_by_name
            // 
            this.filtr_by_name.Location = new System.Drawing.Point(480, 160);
            this.filtr_by_name.Name = "filtr_by_name";
            this.filtr_by_name.Size = new System.Drawing.Size(59, 23);
            this.filtr_by_name.TabIndex = 9;
            this.filtr_by_name.Text = "Name";
            this.filtr_by_name.UseVisualStyleBackColor = true;
            this.filtr_by_name.Click += new System.EventHandler(this.filtr_by_name_Click);
            // 
            // filtr_by_date
            // 
            this.filtr_by_date.Location = new System.Drawing.Point(556, 160);
            this.filtr_by_date.Name = "filtr_by_date";
            this.filtr_by_date.Size = new System.Drawing.Size(58, 23);
            this.filtr_by_date.TabIndex = 10;
            this.filtr_by_date.Text = "Date";
            this.filtr_by_date.UseVisualStyleBackColor = true;
            this.filtr_by_date.Click += new System.EventHandler(this.filtr_by_date_Click);
            // 
            // filtr_by_status
            // 
            this.filtr_by_status.Location = new System.Drawing.Point(629, 160);
            this.filtr_by_status.Name = "filtr_by_status";
            this.filtr_by_status.Size = new System.Drawing.Size(58, 23);
            this.filtr_by_status.TabIndex = 11;
            this.filtr_by_status.Text = "Status";
            this.filtr_by_status.UseVisualStyleBackColor = true;
            this.filtr_by_status.Click += new System.EventHandler(this.filtr_by_status_Click);
            // 
            // filtr_by_length
            // 
            this.filtr_by_length.Location = new System.Drawing.Point(703, 160);
            this.filtr_by_length.Name = "filtr_by_length";
            this.filtr_by_length.Size = new System.Drawing.Size(58, 23);
            this.filtr_by_length.TabIndex = 12;
            this.filtr_by_length.Text = "Length";
            this.filtr_by_length.UseVisualStyleBackColor = true;
            this.filtr_by_length.Click += new System.EventHandler(this.filtr_by_length_Click);
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtr_by_length);
            this.Controls.Add(this.filtr_by_status);
            this.Controls.Add(this.filtr_by_date);
            this.Controls.Add(this.filtr_by_name);
            this.Controls.Add(this.showHistory_btn);
            this.Controls.Add(this.redo_btn);
            this.Controls.Add(this.undo_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_task_btnn);
            this.Controls.Add(this.edit_task_bttn);
            this.Controls.Add(this.create_task_bttn);
            this.Controls.Add(this.task_description);
            this.Controls.Add(this.task_title);
            this.Name = "TaskListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task_title;
        private System.Windows.Forms.TextBox task_description;
        private System.Windows.Forms.Button create_task_bttn;
        private System.Windows.Forms.Button edit_task_bttn;
        private System.Windows.Forms.Button delete_task_btnn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button redo_btn;
        private System.Windows.Forms.Button showHistory_btn;
        private System.Windows.Forms.Button filtr_by_name;
        private System.Windows.Forms.Button filtr_by_date;
        private System.Windows.Forms.Button filtr_by_status;
        private System.Windows.Forms.Button filtr_by_length;
    }
}