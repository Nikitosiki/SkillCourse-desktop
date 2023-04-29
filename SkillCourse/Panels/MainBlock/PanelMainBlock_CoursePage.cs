using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.DataBaseStructure.types;
using SkillCourse.Forms;
using SkillCourse.handlers;
using SkillCourse.helpers;
using SkillCourse.PanelComponents;
using SkillCourse.PanelComponents.CoursePage;
using SkillCourse.PanelComponents.UsersPage;
using SkillCourse.Panels.MainBlock.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
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
        private User? TeacherThis { get; set; }
        private Course CourseThis { get; set; }


        private User user = AccountHandler.Instance.UserLog;

        private List<UserControl> ListPanelStreams { get; set; } = new List<UserControl>();
        private List<UserControl> ListPanelClasswork { get; set; } = new List<UserControl>();
        private List<UserControl> ListPanelPeople { get; set; } = new List<UserControl>();


        public PanelMainBlock_CoursePage(Course course)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            CourseThis = course;
            labelName.Text = CourseThis.Name;
            textBoxDescription.Text = CourseThis.Description;
            string path = SerializeSetting.Default.CourseImages + CourseThis.ImagePath;
            pictureBoxImage.Image = ImageSaveHelper.LoadCourseImageFromFile(path);

            LoatPageForUserType(CourseThis);
        }

        private void LoatPageForUserType(Course course)
        {
            if (user != null)
            {
                if (user.UserType == UserType.Student && ((Student)user).CoursesSubscribed.Any(c => c.Name == course.Name))
                {
                    UpdateThisList(course);
                    AddStreamPanel();
                    return;
                }

                if (user.UserType == UserType.Teacher && ((Teather)user).MyCourses.Any(c => c.Name == course.Name))
                {
                    UpdateThisList(course);
                    AddStreamPanel();
                    AddAdministratorView();
                    return;
                }
            }

            //Происходит если у нас гость, или студент который не подписан на этот курс, или учитель но это не его курс
            tableLayoutPanel5.Visible = false;

            UserControl message = new PanelMainBlock_MessageText("You are not a participant in the course!");
            message.Dock = DockStyle.Fill;
            this.panelTasks.Controls.Add(message);
        }

        #region AdministratorView

        private readonly int maxLenghtName = 80;
        private readonly int maxLenghtDescription = 500;
        SkillCourseDB DataBase = SkillCourseDB.Instance;

        private void AddAdministratorView()
        {
            panelButtonSetting.Visible = true;
        }

        private void ResetAdministratorSettings()
        {
            panelButtonSetting.Visible = true;

            panelEditName.Visible = false;
            roundedButtonEditDescription.Visible = false;
            roundedButtonEditImage.Visible = false;
            roundedButtonEditName.Visible = false;
        }

        private void roundedButtonSetting_Click(object sender, EventArgs e)
        {
            panelButtonSetting.Visible = false;

            panelEditName.Visible = true;
            roundedButtonEditDescription.Visible = true;
            roundedButtonEditImage.Visible = true;
            roundedButtonEditName.Visible = true;
        }

        private void PanelMainBlock_CoursePage_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                ResetAdministratorSettings();
        }

        private void roundedButtonEditName_Click(object sender, EventArgs e)
        {
            Control oldMainParent = SetBaseParent();
            AnswerToTask answerForm = new AnswerToTask(new Size(oldMainParent.ClientSize.Width, oldMainParent.ClientSize.Height),
                labelName.Text, maxLenghtName);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string returnText = answerForm.Text;
                labelName.Text = returnText;
                CourseThis.Name = returnText;
                DataBase.Courses.Update(CourseThis);
            }
        }

        private void roundedButtonEditDescription_Click(object sender, EventArgs e)
        {
            Control oldMainParent = SetBaseParent();
            AnswerToTask answerForm = new AnswerToTask(new Size(oldMainParent.ClientSize.Width, oldMainParent.ClientSize.Height),
                textBoxDescription.Text, maxLenghtDescription);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string returnText = answerForm.Text;
                textBoxDescription.Text = returnText;
                CourseThis.Description = returnText;
                DataBase.Courses.Update(CourseThis);
            }
        }

        private void roundedButtonEditImage_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            if (CourseThis.ImagePath == "" || CourseThis.ImagePath == null)
            {
                imagePath = CourseThis.Name.Replace(" ", "_") + ".png";
                CourseThis.ImagePath = imagePath;
                DataBase.Courses.Update(CourseThis);
            }
            else
            {
                imagePath = CourseThis.ImagePath;
            }
            
            Image? image = ImageSaveHelper.SelectDialogAndSaveImage(ImageSaveHelper.TypeImage.Course, imagePath);
            if (image != null)
                pictureBoxImage.Image = image;
        }

        private Control SetBaseParent()
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }
            return thisParent;
        }

        #endregion AdministratorView

        private void UpdateThisList(Course course)
        {
            StreamTasks = UserHandler.GetAllTasks(course);
            ClassworkTasks = UserHandler.GetOnlyTask(course);
            Students = UserHandler.GetStudents(course);
            TeacherThis = UserHandler.GetTeacher(course);

            ListPanelStreams.Clear();
            ListPanelClasswork.Clear();
            ListPanelPeople.Clear();

            FillListPanelStreams();
            FillListPanelClasswork();
            FillListPanelPeople();
        }

        private void FillListPanelStreams()
        {
            int i = 0;
            foreach (Task task in StreamTasks)
            {
                if (task.TaskTypeMessage)
                    ListPanelStreams.Add(user.UserType == UserType.Student ? new Component_Task(task) : new Component_TaskForTeacher(task));
                else
                    ListPanelStreams.Add(user.UserType == UserType.Student ? new Component_Task(task, ++i) : new Component_TaskForTeacher(task, ++i));
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
                    ListPanelClasswork.Add(user.UserType == UserType.Student ? new Component_Task(task, ++i) : new Component_TaskForTeacher(task, ++i));
            }
            ListPanelClasswork.Reverse();

            if (ListPanelClasswork == null || ListPanelClasswork.Count == 0)
                ListPanelClasswork.Add(new Component_NotTaskMessage());
        }

        private void FillListPanelPeople()
        {
            //--- Учитель

            ListPanelPeople.Add(new Component_UserTextHeader("Teacher"));
            ListPanelPeople.Add(new Component_UserText(TeacherThis));


            //--- Студенты
            if (Students.Any())
                ListPanelPeople.Add(new Component_UserTextHeader("All Users", Students.Count));
            foreach (Student stud in Students)
            {
                ListPanelPeople.Add(new Component_UserText(stud));
            }

            ListPanelPeople.Reverse();
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

        private void ChangeStateButtonSort(bool active)
        {
            if (active)
                buttonSortTasks.Visible = true;
            else
                buttonSortTasks.Visible = false;
        }

        private void AddStreamPanel()
        {
            foreach (UserControl item in ListPanelStreams)
                panelTasks.Controls.Add(item);

            ChangeStateButtonSort(panelTasks.Controls.Count <= 1 ? false : true);

            panelTasks.Refresh();
        }

        private void AddClassworkPanel()
        {
            foreach (UserControl item in ListPanelClasswork)
                panelTasks.Controls.Add(item);

            ChangeStateButtonSort(panelTasks.Controls.Count <= 1 ? false : true);

            panelTasks.Refresh();
        }

        private void AddPeoplePanel()
        {
            foreach (UserControl item in ListPanelPeople)
                panelTasks.Controls.Add(item);

            panelTasks.Refresh();
        }

        private void buttonPanelStream_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выъодим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ButSortTasksDefault();

            ClearThisPanel();
            AddStreamPanel();
        }

        private void buttonPanelClasswork_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выводим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ButSortTasksDefault();

            ClearThisPanel();
            AddClassworkPanel();
        }

        private void buttonPanelPeople_Click(object sender, EventArgs e)
        {
            //если кнопка уже нажата, выводим
            if (((Button)sender).ForeColor == SystemColors.ControlLight)
                return;

            ChangeButtonPanel(sender);
            ChangeStateButtonSort(false);

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

        private bool upSortTasks = true;
        private void buttonSortTasks_Click(object sender, EventArgs e)
        {
            ButSortTasksChangeImage();
            Control[] controlsArray = new Control[panelTasks.Controls.Count];
            panelTasks.Controls.CopyTo(controlsArray, 0);
            Array.Reverse(controlsArray);
            panelTasks.Controls.Clear();
            panelTasks.Controls.AddRange(controlsArray);

            panelTasks.Refresh();


            void ButSortTasksChangeImage()
            {
                Button thisButton = (Button)sender;
                Image upBut = Properties.Resources.ResourceManager.GetObject("arrow-up-341-svgrepo-com-up") as Image;
                Image downBut = Properties.Resources.ResourceManager.GetObject("arrow-up-341-svgrepo-com-down") as Image;


                if (upSortTasks)
                {
                    upSortTasks = false;
                    thisButton.Image = downBut;
                }
                else
                {
                    upSortTasks = true;
                    thisButton.Image = upBut;
                }
            }
        }

        void ButSortTasksDefault()
        {
            Button thisButton = buttonSortTasks;
            Image upBut = Properties.Resources.ResourceManager.GetObject("arrow-up-341-svgrepo-com-up") as Image;

            if (!upSortTasks)
            {
                upSortTasks = true;
                thisButton.Image = upBut;
            }
        }
    }
}
