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

            labelId.Text = "#" + id.ToString();
            labelText.Text = task.TextTask;
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        //Message
        public Component_Task(Task task)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelId.Text = "◆";
            tableLayoutPanel1.Visible = false;
            labelText.Text = task.TextTask;
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }
    }
}
