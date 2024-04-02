namespace TodoList.F
{
    partial class ActionHistoryForm
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
            this.listBoxActions = new System.Windows.Forms.DataGridView();
            this.close_btn = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxActions)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxActions
            // 
            this.listBoxActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBoxActions.Location = new System.Drawing.Point(12, 0);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(410, 339);
            this.listBoxActions.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(489, 38);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // save_file
            // 
            this.save_file.Location = new System.Drawing.Point(489, 94);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(75, 23);
            this.save_file.TabIndex = 2;
            this.save_file.Text = "Save FIle";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // ActionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.listBoxActions);
            this.Name = "ActionHistoryForm";
            this.Text = "ActionHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxActions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listBoxActions;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button save_file;
    }
}