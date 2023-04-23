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
    public partial class PanelMainBlock_UserPage : UserControl
    {
        public PanelMainBlock_UserPage(User user)
        {
            InitializeComponent();

            labelName.Text = user.LastName + " " + user.FirstName;
        }

        private void newButton_Back_Click(object sender, EventArgs e)
        {
            object? parent = this.Parent;

            if (parent != null)
            {
                Panel mainPanel = (Panel)parent;
                mainPanel.Controls.Remove(this);
                mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = true;

            }
        }
    }
}
