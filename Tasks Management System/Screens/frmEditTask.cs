using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static To_Do_List_Project.frmDailyToDoTasks;

namespace To_Do_List_Project
{
    public partial class frmEditTask : Form
    {
        public frmEditTask() => InitializeComponent();

        private string FileName = "Daily Tasks.txt";

        struct stCurrentDetails
        {
            public string CurrentTask;
            public string CurrentDeadLine;
        }

        stCurrentDetails CurrentDetails;

        public frmEditTask(string CurrentTask, string CurrentDeadLine)
        {
            //In C# : when we use parametrized constructor , the default constructor will not be called automatically , so we must put initialize component in the parametrized constructor.
            //In C++ : When we define parametrized constructor , it will automatically excecute default constructor first whether we define it or not and the it will excecute the parametrized constructor.
            InitializeComponent();
            CurrentDetails.CurrentTask = CurrentTask;
            CurrentDetails.CurrentDeadLine = CurrentDeadLine;

        }

        public void SaveDataToFile(List<stTaskInfo> lTasks)
        {
            using (StreamWriter MyFile = new StreamWriter(FileName))
            {
                foreach (stTaskInfo T in lTasks)
                {
                    MyFile.WriteLine(T.Task + "#//#" + T.DeadLine);
                }
            }

        }

        private List<stTaskInfo> _EditTask(stCurrentDetails Details)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();

            lTasks = frmDailyToDoTasks.LoadFileDate(FileName);

            stTaskInfo NewTask;

            for (short i = 0; i < lTasks.Count; i++)
            {
                if (lTasks[i].Task == Details.CurrentTask || lTasks[i].DeadLine == Details.CurrentDeadLine)
                {
                    NewTask.Task = txtTask.Text;
                    NewTask.DeadLine = txtDeadLine.Text;
                    NewTask.MarkForDelete = false;

                    lTasks[i] = NewTask;


                }
            }
            return lTasks;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            SaveDataToFile(_EditTask(CurrentDetails));
            MessageBox.Show("Task Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form frmDailyTasks = new frmDailyToDoTasks();
            frmDailyTasks.Show();
            this.Close();
        }

        private void frmEditTask_Load(object sender, EventArgs e)
        {
            txtTask.Text = CurrentDetails.CurrentTask;
            txtDeadLine.Text = CurrentDetails.CurrentDeadLine;
        }
    }
}
