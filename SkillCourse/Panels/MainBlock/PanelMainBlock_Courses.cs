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


        public bool AddCourseToFlowLayoutPanel(List<Course> Course)
        {
            foreach (Course course in Course)
            {
                UserControl userControl = new Component_BriefСourse(course.Name, course.Description, (Image)Properties.Resources.ResourceManager.GetObject(course.ImagePath), () => openPageCourse(new PanelMainBlock_CoursePage()));
                flowLayoutPanel1.Controls.Add(userControl);
            }
            return true;
        }

        //public async System.Threading.Tasks.Task<ControlCollection> dasdas(List<Course> Course)
        //{
        //    ControlCollection temp = new ControlCollection(this);
        //    foreach (Course course in Course)
        //    {
        //        temp.Add(new Component_BriefСourse(course.Name, course.Description,
        //            (Image)Properties.Resources.ResourceManager.GetObject(course.ImagePath),
        //            () => openPageCourse(new PanelMainBlock_CoursePage())));
        //    }

        //    return temp;
        //}

        //private async void PanelMainBlock_Courses_Load(object sender, EventArgs e)
        //{
        //    collection = await System.Threading.Tasks.Task.Run(() => dasdas(SkillCourseDB.Instance.Courses));
        //}


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
    }
}
