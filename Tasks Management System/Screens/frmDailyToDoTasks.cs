using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace To_Do_List_Project
{
    public partial class frmDailyToDoTasks : Form
    {
        public frmDailyToDoTasks() => InitializeComponent();
       


        private string FileName = "Daily Tasks.txt";

        public struct stTaskInfo
        {
            public string Task;
            public string DeadLine;
            public bool MarkForDelete;
        }


        internal void AddNodesToTreeView(string RootNodeTask, string ChildNodeDeadLine)
        {
            if (RootNodeTask != null)
            {
                trvTasks.Nodes.Add(RootNodeTask);
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].ForeColor = Color.White;
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].NodeFont = new Font("Times New Roman", 22, FontStyle.Bold);

            }

            if (ChildNodeDeadLine != null)
            {
                trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes.Add(ChildNodeDeadLine);
                trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes[(trvTasks.Nodes[(trvTasks.Nodes.Count) - 1].Nodes.Count) - 1].ForeColor = Color.White;
                trvTasks.Nodes[trvTasks.Nodes.Count - 1].Nodes[trvTasks.Nodes[trvTasks.Nodes.Count - 1].Nodes.Count - 1].NodeFont = new Font("Times New Roman", 20, FontStyle.Bold);
            }

        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmNewTask = new frmNewTaskInfo();
            frmNewTask.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMainScreen = new frmMain();
            frmMainScreen.Show();
            this.Close();
        }


        public static List<stTaskInfo> LoadFileDate(string FileName)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();
            List<string> slTasks = new List<string>();

            stTaskInfo TaskInfo;

            using (StreamReader MyFile = new StreamReader(FileName))
            {
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    slTasks = Line.Split(new String[] { "#//#" }, StringSplitOptions.RemoveEmptyEntries).Where(s => !String.IsNullOrEmpty(s)).ToList();
                    TaskInfo.Task = slTasks.ElementAt(0);
                    TaskInfo.DeadLine = slTasks.ElementAt(1);
                    TaskInfo.MarkForDelete = false;

                    lTasks.Add(TaskInfo);

                    slTasks.Clear();

                }

            }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lTasks;
        }

        private void _AddTasks()
        {
            if (File.Exists(FileName))

            {
                List<stTaskInfo> lTasks = new List<stTaskInfo>();
                lTasks = LoadFileDate(FileName);

                foreach (stTaskInfo Info in lTasks)
                {
                    AddNodesToTreeView(Info.Task, Info.DeadLine);
                }
            }
        }
        private void frmDailyToDoTasks_Load(object sender, EventArgs e)
        {
            _AddTasks();
        }
        private void _UpdateDataToFile(List<stTaskInfo> lTasks)
        {
            //using(StreamWriter MyFile=new StreamWriter(FileName,append:true))//will not clear the file but it will append and if the file not exist it will create it 
            using (StreamWriter MyFile = new StreamWriter(FileName))//apend defalut parameter -> false
            {
                //MyFile.Flush();// the text is not directly will by written on file but it will be stored at memory in : buffer , and when the file closed , disposed , it will writes the texts in buffer to disk, flush () here will force to write what inside buffer now to be written in file in harddisk, .dispose automatically flush -> to make the buffer data be written on the file
                foreach (stTaskInfo Task in lTasks)
                {
                    if (!Task.MarkForDelete)
                    {//Writing data to memory (buffer) is much faster than write it to disk rightaway -> better prefomance for writing data to buffer in memory and afte closeing the file it will write to file in harddisk
                        //If you flush every time you write a line, the program makes many slow disk writes.
                        //Flushing Frequently can wear out ssd's if done excessively
                        MyFile.WriteLine(Task.Task + "#//#" + Task.DeadLine);
                    }
                }
            }
        }

        private void _DeleteTaskFromFile(string TaskToDelete)
        {
            List<stTaskInfo> lTasks = new List<stTaskInfo>();
            lTasks = LoadFileDate(FileName);

            stTaskInfo Task;

            for (short i = 0; i < lTasks.Count; i++)
            {
                if (lTasks[i].Task == TaskToDelete || lTasks[i].DeadLine == TaskToDelete)
                {
                    Task.MarkForDelete = true;
                    Task.Task = TaskToDelete;
                    Task.DeadLine = lTasks[i].DeadLine;
                    lTasks[i] = Task;
                }
            }
            _UpdateDataToFile(lTasks);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (trvTasks.Nodes.Count == 0)
            { MessageBox.Show("You did'nt set your daily tasks yet", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else
            {
                _DeleteTaskFromFile(trvTasks.SelectedNode.Text);

                foreach (TreeNode node in trvTasks.Nodes)
                {
                    if (node == trvTasks.SelectedNode)
                    {
                        node.Remove();
                        return;
                    }

                }
                trvTasks.SelectedNode.Parent.Remove();
            }
        }

        private void btnDeleteAllTasks_Click(object sender, EventArgs e)
        {
            if (trvTasks.Nodes.Count == 0)
             MessageBox.Show("You did'nt set your daily tasks yet", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {

                File.Delete(FileName);

                trvTasks.Nodes.Clear();

             
            }
        }



        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (trvTasks.Nodes.Count == 0)
                MessageBox.Show("Add a task first then you can edit", "Choose a task", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                Form frmEditTask = new frmEditTask(trvTasks.SelectedNode.Text, trvTasks.SelectedNode.Nodes[0].Text);
                frmEditTask.Show();
                this.Close();

            }
        }
    }
}
