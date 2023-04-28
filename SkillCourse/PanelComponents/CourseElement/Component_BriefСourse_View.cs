using SkillCourse.DataBaseStructure;
using SkillCourse.DataBaseStructure.serialize;
using SkillCourse.helpers;
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
            string path = SerializeSetting.Default.CourseImages + course.ImagePath;
            picture_imageCourse.Image = ImageSaveHelper.LoadCourseImageFromFile(path);

            clickOnCourse = buttonCoutse;
        }

        private void button_ViewCourse_Click(object sender, EventArgs e)
        {
            clickOnCourse?.Invoke();
        }
    }
}
