using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.PanelComponents;
using SkillCourse.PanelComponents.CoursePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_CoursePage : UserControl
    {
        private List<Task> StreamTasks { get; set; }
        private List<Task> ClassworkTasks { get; set; }
        private List<Student> Students { get; set; }
        private User Teacher { get; set; }


        public Student handler = (Student)AccountHandler.Instance.UserLog;

        private List<UserControl> ListPanelStreams { get; set; } = new List<UserControl>();
        private List<UserControl> ListPanelClasswork { get; set; } = new List<UserControl>();
        //private List<UserControl> ListPanelPeople { get; set; } = new List<UserControl>();


        public PanelMainBlock_CoursePage(Course course)
        {
            InitializeComponent();

            labelName.Text = course.Name;
            textBoxDescription.Text = course.Description;
            pictureBoxImage.Image = Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image;

            UpdateThisList(course);
            AddStreamPanel();
        }

        private void UpdateThisList(Course course)
        {
            StreamTasks = handler.GetAllTasks(course);
            ClassworkTasks = handler.GetOnlyTask(course);
            Students = handler.GetStudents(course);
            Teacher = handler.GetTeacher(course);

            ListPanelStreams.Clear();
            ListPanelClasswork.Clear();

            FillListPanelStreams();
            FillListPanelClasswork();
        }

        private void FillListPanelStreams()
        {
            int i = 0;
            foreach (Task task in StreamTasks)
            {
                if (task.TaskTypeMessage)
                    ListPanelStreams.Add(new Component_Task(task));
                else
                    ListPanelStreams.Add(new Component_Task(task, ++i));
            }
            ListPanelStreams.Reverse();

            if (ListPanelStreams == null || ListPanelStreams.Count == 0)
                ListPanelStreams.Add(new Component_NotTaskMessage());
        }

        private void FillListPanelClasswork()
        {
            int i = 0;
            foreach (Task task in ClassworkTasks)
            {
                if (!task.TaskTypeMessage)
                    ListPanelClasswork.Add(new Component_Task(task, ++i));
            }
            ListPanelClasswork.Reverse();

            if (ListPanelClasswork == null || ListPanelClasswork.Count == 0)
                ListPanelClasswork.Add(new Component_NotTaskMessage());
        }

        private void ChangeButtonPanel(object sender)
        {
            foreach (Control item in tableLayoutPanel5.Controls)
            {
                if (item.Name == ((Button)sender).Name)
                {
                    if (item.ForeColor == SystemColors.ControlLight)
                        continue;

                    item.ForeColor = SystemColors.ControlLight;
                }
                else
                    item.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void ClearThisPanel()
        {
            panelTasks.Controls.Clear();
        }

        private void AddStreamPanel()
        {
            foreach (UserControl item in ListPanelStreams)
                panelTasks.Controls.Add(item);

            panelTasks.Refresh();
        }

        private void AddClassworkPanel()
        {
            foreach (UserControl item in ListPanelClasswork)
                panelTasks.Controls.Add(item);

            panelTasks.Refresh();
        }

        private void AddPeoplePanel()
        {
            //foreach (UserControl item in ListPanelStreams)
            //    panelTasks.Controls.Add(item);

            //panelTasks.Refresh();
        }

        private void buttonPanelStream_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выъодим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ClearThisPanel();
            AddStreamPanel();
        }

        private void buttonPanelClasswork_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выъодим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ClearThisPanel();
            AddClassworkPanel();
        }

        private void buttonPanelPeople_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выъодим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ClearThisPanel();
            AddPeoplePanel();
        }



        private void newButton_Back_Click(object sender, EventArgs e)
        {
            object? parent = this.Parent;
            //UserControl control = new PanelMainBlock_Courses();

            if (parent != null)
            {
                Panel mainPanel = (Panel)parent;
                mainPanel.Controls.Remove(this);
                mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = true;

                //Panel mainPanel = (Panel)parent;
                //string text = mainPanel.Name;

                //if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != control)
                //{
                //    mainPanel.Controls.Clear();
                //    mainPanel.Controls.Add(control);
                //}
            }
        }
    }
}
