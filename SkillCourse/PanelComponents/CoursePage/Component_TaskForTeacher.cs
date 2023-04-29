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
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.PanelComponents.CoursePage
{
    public partial class Component_TaskForTeacher : UserControl
    {
        public Component_TaskForTeacher(Task task)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            //labelId.Text = "◆";
            labelId.Text = "";
            labelId.Image = Properties.Resources.task_message;

            labelText.Text = task.TextTask + "        ";
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        public Component_TaskForTeacher(Task task, int id)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelId.Text = "#" + id.ToString();
            labelText.Text = task.TextTask + "        ";
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        public void AdminView(bool admin)
        {
            tableLayoutPanelAdmin.Visible = admin;
        }

        private void labelText_TextChanged(object sender, EventArgs e)
        {
            ReSizeDescription();
        }

        private void tableLayoutPanel3_Resize(object sender, EventArgs e)
        {
            ReSizeDescription();
        }
        private void ReSizeDescription()
        {
            panelText.Size = new System.Drawing.Size(labelText.Width, labelText.Height);
        }

    }
}
