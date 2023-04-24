using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkillCourse.Panels.MainBlock.PanelMainBlock_Courses;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Message_NoCourses : UserControl
    {
        public PanelMainBlock_Message_NoCourses()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NavigatePages.OpenNewPage(new PanelMainBlock_Courses(ViewCourseState.All, false, true));
        }
    }
}
