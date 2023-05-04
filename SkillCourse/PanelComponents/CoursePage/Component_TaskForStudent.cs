using SkillCourse.DataBaseStructure;
using SkillCourse.Forms;
using SkillCourse.helperConfig;
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
    public partial class Component_TaskForStudent : UserControl
    {
        public Student handler = (Student)AccountHandler.Instance.UserLog;
        public Task ThisTask { get; private set; }
        private Action<UserControl> clickOnSend;

        //Task
        public Component_TaskForStudent(Task task, int id)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            ThisTask = task;

            labelId.Text = "#" + id.ToString();
            labelText.Text = task.TextTask;
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));

            UpdateStateAnsverTask(task);
        }

        public Component_TaskForStudent(Task task, int id, Action<UserControl> onClickButtonSend)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            ThisTask = task;
            clickOnSend = onClickButtonSend;

            labelId.Text = "#" + id.ToString();
            labelText.Text = task.TextTask;
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));

            UpdateStateAnsverTask(task);
        }

        //Message
        public Component_TaskForStudent(Task task)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            //labelId.Text = "◆";
            labelId.Text = "";
            labelId.Image = Properties.Resources.task_message;

            labelText.Text = task.TextTask;
            ReSizeDescription();
            labelDate.Text = task.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"));

            panelButSend.Hide();
            labelStatus.Hide();
            compGrade.Hide();
            Tag = "Message";
        }


        private void UpdateStateAnsverTask(Task task)
        {
            if (handler.CheckCompletedOrGradeTask(task))
            {
                if (handler.GetGradeToTask(task) is int grade)
                {
                    panelButSend.Hide();
                    labelStatus.Hide();
                    compGrade.Show();

                    compGrade.Grade = grade;
                }
                else
                {
                    // Если у нас нету оценки
                    panelButSend.Hide();
                    labelStatus.Show();
                    compGrade.Hide();

                    labelStatus.Text = handler.GetStatusTask(task);
                }
            }
            else
            {
                panelButSend.Show();
                labelStatus.Hide();
                compGrade.Hide();
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

        private void newButtonSend_Click(object sender, EventArgs e)
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }

            AnswerToTask answerForm = new AnswerToTask(new Size(thisParent.ClientSize.Width, thisParent.ClientSize.Height),
                String.Empty, UserTextSize.AnswerTask.maxLenghtName, false);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string returnText = answerForm.Text;

                handler.CompleteTask(ThisTask, returnText);
                UpdateStateAnsverTask(ThisTask);
                clickOnSend?.Invoke(this);
                //MessageBox.Show("Введенный текст: " + returnText);
            }
        }
    }
}
