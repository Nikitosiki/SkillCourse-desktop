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
        //public static ControlCollection collection = null;

        public PanelMainBlock_Courses()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            SkillCourseDB DataBase = SkillCourseDB.Instance;
            AddCourseToFlowLayoutPanel(DataBase.Courses);
        }

        #region LoadPage

        public bool AddCourseToFlowLayoutPanel(List<Course> Course)
        {
            foreach (Course course in Course)
            {
                UserControl userControl = new Component_BriefСourse(course.Name, course.Description, (Image)Properties.Resources.ResourceManager.GetObject(course.ImagePath), () => openPageCourse(new PanelMainBlock_CoursePage()));
                flowLayoutPanel1.Controls.Add(userControl);
            }
            return true;

        }

        private void openPageCourse(UserControl Content)
        {
            object? parent = this.Parent;

            if (parent != null)
            {
                Panel mainPanel = (Panel)parent;

                if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != Content)
                {
                    mainPanel.Controls.Clear();
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
            ControlCollection sortedCollection = new ControlCollection(flowLayoutPanel1);

            //Востанавливаем все елементы после поиска
            if (textBox1.Text == "" || textBox1.Text == " ")
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    item.Visible = true;
                }

            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.Visible == false)
                    continue;

                if (!item.Name.Contains(textBox1.Text))
                    item.Visible = false;
            }
        }
    }
}
