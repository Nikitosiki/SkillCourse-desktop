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

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_AddCourses : UserControl
    {
        public PanelMainBlock_AddCourses()
        {
            InitializeComponent();
        }

        private void PublicCourse_Click(object sender, EventArgs e)
        {
            SkillCourseDB DataBase = SkillCourseDB.Instance;

            Course course = new Course(textBox_NameCourse.Text, textBox_DescriptionCourse.Text, Properties.Resources.image008, 0);
            DataBase.Courses.Add(course);
        }
    }
}
