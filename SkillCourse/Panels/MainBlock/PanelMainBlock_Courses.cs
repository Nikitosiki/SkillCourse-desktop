using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock
{
    public partial class PanelMainBlock_Courses : UserControl
    {
        public PanelMainBlock_Courses()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton3_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton4_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton5_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton6_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
        }

        private void newButton7_Click(object sender, EventArgs e)
        {
            openPageCourse(new PanelMainBlock_CoursePage());
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
    }
}
