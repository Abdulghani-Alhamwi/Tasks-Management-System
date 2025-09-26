using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace To_Do_List_Project
{
    public partial class frmNewTaskInfo : Form
    {
        public frmNewTaskInfo()
        {
            InitializeComponent();
        }

        public void SaveDataToFile()
        {
            if (txtTask.Text == null || txtDeadLine.Text == null)
                MessageBox.Show("Please enter task and deadline to add the task to your daily tasks", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {


                //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
                //{
                //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
                //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
                //}

                //File.AppendAllText("Daily Tasks File.txt", txtTask.Text + "#//#" + txtDeadLine.Text);
                //the previous line closes the file automatically and creates the file if it is not exists and append to the file if it is exists , so it is a shortcut for :
                //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
                //{
                //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
                //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
                //}

                //File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + Environment.NewLine()    );//Automatically closes the file and creates it if it is not exists
                File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + "\r\n");//Automatically closes the file and creates it if it is not exists

                MessageBox.Show("Task Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form frmDailyTasks = new frmDailyToDoTasks();
                frmDailyTasks.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveDataToFile();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
            this.Close();
        }
    }
}
