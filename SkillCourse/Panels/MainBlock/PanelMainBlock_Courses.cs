using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
using SkillCourse.PanelComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Courses : UserControl
    {
        public Student handlerStud = (Student)AccountHandler.Instance.UserLog;

        List<Course> thisCourses;
        private bool VisibleButView { get; set; }
        private bool VisibleButSub { get; set; }

        public PanelMainBlock_Courses(ViewCourseState stateView, bool buttonView, bool buttonSub)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            thisCourses = stateView == ViewCourseState.My ? handlerStud.CoursesSubscribed : SkillCourseDB.Instance.Courses;

            VisibleButView = buttonView;
            VisibleButSub = buttonSub;

            string view = VisibleButView ? "View" : "";
            string sub = VisibleButSub ? "Sub" : "";

            Name = $"{Name} {VisibleButView} {VisibleButSub} {ViewCourseState.My}";

            //Если пользователь не авторизовался, сортировать список он не может
            if (handlerStud == null)
                customComboBox1.Visible = false;
        }


        #region LoadPage
        private async void PanelMainBlock_Courses_Load(object sender, EventArgs e)
        {
            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            await System.Threading.Tasks.Task.Run(() =>
            {
                flowLayoutPanel1.Invoke((MethodInvoker)delegate
                {
                    flowLayoutPanel1.Controls.Clear();
                });

                foreach (Course course in thisCourses)
                {
                    UserControl userControl = CreateCourse(course);

                    // Используем метод Invoke, чтобы добавить элемент в контексте потока пользовательского интерфейса
                    flowLayoutPanel1.Invoke((MethodInvoker)delegate
                    {
                        flowLayoutPanel1.Controls.Add(userControl);
                    });
                }
            });
        }

        private UserControl CreateCourse(Course course)
        {
            if (VisibleButView)
                return new Component_BriefСourse_View(course, () => openPageCourse(new PanelMainBlock_CoursePage(course)));
            if (VisibleButSub)
                return new Component_BriefСourse_Subscription(course, true, () => openPageCourse(new PanelMainBlock_CoursePage(course)), null);
            return new Component_BriefСourse_Base(course);

        }

        private void openPageCourse(UserControl Content)
        {
            object? parent = this.Parent;

            if (parent != null)
            {
                Panel mainPanel = (Panel)parent;

                if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != Content)
                {
                    mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = false;
                    mainPanel.Controls.Add(Content);
                }
            }
        }

        #endregion


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Востанавливаем все елементы после поиска
            if (textBoxSearcher.Text.Trim() == "")
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    item.Visible = true;
                }

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.Visible == false)
                    continue;

                // if (!((Component_BriefСourse)item).Dab.Contains(textBox1.Text))
                if (!item.Name.Contains(textBoxSearcher.Text))
                    item.Visible = false;
            }
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (customComboBox1.SelectedIndex)
            {
                case 0:     //Name
                    handlerStud.SortCoursesByName(ref thisCourses);
                    PanelMainBlock_Courses_Load(this, e);
                    break;

                case 1:     //Subcrib
                    handlerStud.SortCoursesBySubscription(ref thisCourses);
                    PanelMainBlock_Courses_Load(this, e);
                    break;
            }
        }

        public enum ViewCourseState
        {
            My,
            All
        }
    }
}
