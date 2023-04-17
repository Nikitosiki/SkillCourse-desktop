using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.PanelComponents
{
    public partial class Component_Task : UserControl
    {
        //Task
        public Component_Task(Task task, int id)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelBall.Visible = true;
            labelId.Text = "#" + id.ToString();
            labelText.Text = task.TextTask + "        ";
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        //Message
        public Component_Task(Task task)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            //labelId.Text = "◆";
            labelId.Text = "";
            labelId.Image = Properties.Resources.task_message;

            panelButSend.Visible = false;
            labelBall.Visible = false;
            labelText.Text = task.TextTask + "        ";
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        private void labelText_TextChanged(object sender, EventArgs e)
        {
            ReSizeDescription();
        }

        private void ReSizeDescription()
        {
            panelText.Size = new System.Drawing.Size(labelText.Width, labelText.Height);
        }
    }
}
