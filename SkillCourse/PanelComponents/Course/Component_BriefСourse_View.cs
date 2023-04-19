using SkillCourse.DataBaseStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents
{
    public partial class Component_BriefСourse_View : UserControl
    {
        private Action clickOnCourse;

        public Component_BriefСourse_View(Course course, Action buttonCoutse)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            Name = course.Name + " " + course.Description;

            label_NameCourse.Text = course.Name;
            label_DescriptionCourse.Text = course.Description;
            picture_imageCourse.Image = Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image;

            clickOnCourse = buttonCoutse;
        }

        private void button_ViewCourse_Click(object sender, EventArgs e)
        {
            clickOnCourse?.Invoke();
        }
    }
}
