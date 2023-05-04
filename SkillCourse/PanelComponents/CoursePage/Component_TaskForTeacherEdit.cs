using SkillCourse.DataBaseStructure;
using SkillCourse.Forms;
using SkillCourse.helperConfig;
using SkillCourse.Panels.MainBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Task = SkillCourse.DataBaseStructure.Task;

namespace SkillCourse.PanelComponents.CoursePage
{
    public partial class Component_TaskForTeacherEdit : UserControl
    {
        private Task TaskThis { get; set; }

        public Component_TaskForTeacherEdit(Task task)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            //labelId.Text = "◆";
            labelId.Text = "";
            labelId.Image = Properties.Resources.task_message;

            TaskThis = task;
            labelText.Text = TaskThis.TextTask;
            ReSizeDescription();
            labelDate.Text = TaskThis.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));

            Tag = "Message";
        }

        public Component_TaskForTeacherEdit(Task task, int id)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            TaskThis = task;
            labelId.Text = "#" + id.ToString();
            labelText.Text = TaskThis.TextTask;
            ReSizeDescription();
            labelDate.Text = TaskThis.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));
        }

        public void AdminView(bool admin)
        {
            tableLayoutPanelAdmin.Visible = admin;
        }

        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            Control oldMainParent = SetBaseParent();
            AnswerToTask answerForm = new AnswerToTask(new Size(oldMainParent.ClientSize.Width, oldMainParent.ClientSize.Height),
                labelText.Text, UserTextSize.Task.maxLenghtName);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string returnText = answerForm.Text;
                labelText.Text = returnText;
                TaskThis.TextTask = returnText;
                SkillCourseDB.Instance.Tasks.Update(TaskThis);
            }
        }

        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            string text = "Are you sure that you want to delete this task? 🤨";
            Control oldMainParent = SetBaseParent();
            MessageYesNo modalForm = new MessageYesNo(text, new Size(oldMainParent.ClientSize.Width, oldMainParent.ClientSize.Height));
            modalForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = modalForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                SkillCourseDB.Instance.Tasks.Remove(TaskThis);

                if (SetParent() is PanelMainBlock_CoursePage control)
                {
                    control.ListPanelStreams.Remove(this);
                    control.ReLoadThisPanel();
                }
            }
        }


        private Control SetBaseParent()
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }
            return thisParent;
        }

        private Control? SetParent()
        {
            Control? thisParent = this;
            while (true)
            {
                if (thisParent == null)
                    return null;

                if (thisParent.Parent is PanelMainBlock_CoursePage)
                    return thisParent.Parent;

                thisParent = thisParent.Parent;
            }
        }

        private void labelText_TextChanged(object sender, EventArgs e)
        {
            ReSizeDescription();
        }

        private void tableLayoutPanel3_Resize(object sender, EventArgs e)
        {
            ReSizeDescription();
        }

        //private void ReSizeDescription()
        //{
        //    System.Windows.Forms.Label thisLabel = labelText;
        //    System.Windows.Forms.Panel thispanel = panelText;

        //    Size textSize = TextRenderer.MeasureText(thisLabel.Text, thisLabel.Font,
        //        new Size(thisLabel.Size.Width - thisLabel.Padding.Horizontal, thisLabel.Size.Height),
        //        TextFormatFlags.WordBreak);
        //    thispanel.Size = new System.Drawing.Size(thisLabel.Width, textSize.Height);
        //}
        private void ReSizeDescription()
        {
            panelText.Size = new System.Drawing.Size(labelText.Width - labelText.Padding.Horizontal, labelText.Height);
        }
    }
}
