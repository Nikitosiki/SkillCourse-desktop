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
        private bool VisibleButView { get; set; }
        private bool VisibleButSub { get; set; }

        public PanelMainBlock_Courses(bool buttonView, bool buttonSub)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            VisibleButView = buttonView;
            VisibleButSub = buttonSub;
        }

        #region LoadPage

        //public bool AddCourseToFlowLayoutPanel(List<Course> Course)
        //{
        //    foreach (Course course in Course)
        //    {
        //        UserControl userControl = new Component_BriefСourse(course.Name, course.Description, Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image, () => openPageCourse(new PanelMainBlock_CoursePage()));
        //        flowLayoutPanel1.Controls.Add(userControl);
        //    }
        //    return true;

        //}


        private async void PanelMainBlock_Courses_Load(object sender, EventArgs e)
        {
            // Вызываем метод, который будет добавлять элементы в фоновом потоке
            await System.Threading.Tasks.Task.Run(() =>
            {
                foreach (Course course in SkillCourseDB.Instance.Courses)
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
                return new Component_BriefСourse_View(course.Name, course.Description, Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image, () => openPageCourse(new PanelMainBlock_CoursePage()));
            else
                return new Component_BriefСourse_Base(course.Name, course.Description, Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image);

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


        //public List<Course> FindAllCourses(string search)
        //{
        //    string[] searchWords = search.Split(' '); // разбиваем на отдельные слова
        //    return DataBase.Courses
        //        .Where(course => searchWords.Any(word =>
        //            course.Name.Contains(word) || course.Description.Contains(word)))
        //        .ToList();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Востанавливаем все елементы после поиска
            if (textBox1.Text.Trim() == "")
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    item.Visible = true;
                }

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.Visible == false)
                    continue;

                // if (!((Component_BriefСourse)item).Dab.Contains(textBox1.Text))
                if (!item.Name.Contains(textBox1.Text))
                    item.Visible = false;
            }
        }
    }
}
