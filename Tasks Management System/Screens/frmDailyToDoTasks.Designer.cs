namespace To_Do_List_Project
{
    partial class frmDailyToDoTasks
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
            this.trvTasks = new System.Windows.Forms.TreeView();
            this.lblDailyTasks = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteAllTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trvTasks
            // 
            this.trvTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.trvTasks.Font = new System.Drawing.Font("Tahoma", 20F);
            this.trvTasks.Indent = 50;
            this.trvTasks.ItemHeight = 40;
            this.trvTasks.LineColor = System.Drawing.Color.Lime;
            this.trvTasks.Location = new System.Drawing.Point(-7, 109);
            this.trvTasks.Name = "trvTasks";
            this.trvTasks.Size = new System.Drawing.Size(912, 462);
            this.trvTasks.TabIndex = 0;
            // 
            // lblDailyTasks
            // 
            this.lblDailyTasks.AutoSize = true;
            this.lblDailyTasks.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.lblDailyTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lblDailyTasks.Location = new System.Drawing.Point(267, 16);
            this.lblDailyTasks.Name = "lblDailyTasks";
            this.lblDailyTasks.Size = new System.Drawing.Size(364, 71);
            this.lblDailyTasks.TabIndex = 1;
            this.lblDailyTasks.Text = "Daily Tasks";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnDeleteTask.Location = new System.Drawing.Point(79, 617);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(232, 65);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnAddTask.Location = new System.Drawing.Point(591, 617);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(232, 65);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnBack.Location = new System.Drawing.Point(79, 725);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 65);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnEditTask.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnEditTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnEditTask.Location = new System.Drawing.Point(333, 617);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(232, 65);
            this.btnEditTask.TabIndex = 9;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteAllTasks
            // 
            this.btnDeleteAllTasks.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAllTasks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAllTasks.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnDeleteAllTasks.Location = new System.Drawing.Point(541, 723);
            this.btnDeleteAllTasks.Name = "btnDeleteAllTasks";
            this.btnDeleteAllTasks.Size = new System.Drawing.Size(282, 69);
            this.btnDeleteAllTasks.TabIndex = 10;
            this.btnDeleteAllTasks.Text = "Delete all tasks";
            this.btnDeleteAllTasks.UseVisualStyleBackColor = false;
            this.btnDeleteAllTasks.Click += new System.EventHandler(this.btnDeleteAllTasks_Click);
            // 
            // frmDailyToDoTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(900, 815);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteAllTasks);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.lblDailyTasks);
            this.Controls.Add(this.trvTasks);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(916, 854);
            this.MinimumSize = new System.Drawing.Size(916, 854);
            this.Name = "frmDailyToDoTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Your Tasks";
            this.Load += new System.EventHandler(this.frmDailyToDoTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvTasks;
        private System.Windows.Forms.Label lblDailyTasks;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteAllTasks;
    }
}

