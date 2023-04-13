using Microsoft.VisualBasic.Devices;
using SkillCourse.DataBaseStructure;
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
    public partial class PanelMainBlock_CoursePage : UserControl
    {
        public PanelMainBlock_CoursePage(Course course)
        {
            InitializeComponent();

            labelName.Text = course.Name;
            textBoxDescription.Text = course.Description;
            pictureBoxImage.Image = Properties.Resources.ResourceManager.GetObject(course.ImagePath) as Image;
        }

        private void newButton_Back_Click(object sender, EventArgs e)
        {
            object? parent = this.Parent;
            //UserControl control = new PanelMainBlock_Courses();

            if (parent != null)
            {
                Panel mainPanel = (Panel)parent;
                mainPanel.Controls.Remove(this);
                mainPanel.Controls[mainPanel.Controls.Count - 1].Visible = true;

                //Panel mainPanel = (Panel)parent;
                //string text = mainPanel.Name;

                //if (mainPanel.Controls.Count < 1 || mainPanel.Controls[0] != control)
                //{
                //    mainPanel.Controls.Clear();
                //    mainPanel.Controls.Add(control);
                //}
            }
        }
    }
}
