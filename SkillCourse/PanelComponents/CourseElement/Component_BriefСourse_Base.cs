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
    public partial class Component_BriefСourse_Base : UserControl
    {

        public Component_BriefСourse_Base(Course course)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            Name = course.Name + " " + course.Description;

            label_NameCourse.Text = course.Name;
            label_DescriptionCourse.Text = course.Description;
            string path = SerializeSetting.Default.UserImages + course.ImagePath;
            picture_imageCourse.Image = ImageSaveHelper.LoadCourseImageFromFile(course.ImagePath);
        }
    }
}
