using SkillCourse.DataBaseStructure;
using SkillCourse.Panels.MainBlock.Navbar.NavigationButtonEvents;
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
            if (AccountHandler.Instance.UserLog is Student stud)
                StudentButtonEvents.Course_PublicClick();

            if (AccountHandler.Instance.UserLog is Teather teac)
                TeacherButtonEvents.Course_CreateClick();
        }
    }
}
