using SkillCourse.DataBaseStructure;
using SkillCourse.Forms;
using SkillCourse.handlers;
using SkillCourse.helperConfig;
using SkillCourse.Panels.MainBlock;
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
    public partial class Component_AnswerTaskForTeacher : UserControl
    {
        private Teather handler = (Teather)AccountHandler.Instance.UserLog;
        private AnswerTask ThisAnswerTask { get; set; }
        private Task ThisTask { get; set; }
        private Student ThisStudent { get; set; }

        private Action<UserControl> clickOnThis;

        //Task
        public Component_AnswerTaskForTeacher(AnswerTask answer, int id, Action<UserControl> onClick)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            ThisTask = handler.GetTask(answer) ?? throw new Exception("No answer found!");
            ThisAnswerTask = answer;
            ThisStudent = UserHandler.GetStudent(answer) ?? throw new Exception("No user found!"); ;

            labelId.Text = "#" + id.ToString();
            labelText.Text = ThisTask.TextTask;
            labelDate.Text = $"Task public date: " + ThisTask.TaskStartTime.ToString("dd MMM. yyyy 'г.'", new System.Globalization.CultureInfo("en-US"))
                + $"\nStudent: {ThisStudent.FirstName} {ThisStudent.LastName}";

            clickOnThis = onClick;
            ReSizeDescription();
            UpdateStateBall(ThisAnswerTask);
            AddMouseHandlers(this);     // ThisHover
        }


        private void UpdateStateBall(AnswerTask answer)
        {
            if (answer.Grade != null)
            {
                component_Grade.Show();
                component_Grade.Grade = answer.Grade ?? 0;
            }
            else
                component_Grade.Hide();
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
            panelText.Size = new System.Drawing.Size(labelText.Width - labelText.Padding.Horizontal, labelText.Height);
        }


        private void clickOnThisControl(object sender, EventArgs e)
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }

            CheckingAnswerToTask answerForm = new CheckingAnswerToTask(new Size(thisParent.ClientSize.Width, thisParent.ClientSize.Height),
                ThisTask, ThisAnswerTask);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                //Что-то ещё, к примеру обновление БД
                UpdateStateBall(ThisAnswerTask);
                clickOnThis?.Invoke(this);
            }
        }

        #region ThisHover

        private System.Windows.Forms.Timer hoverEventTimer = new System.Windows.Forms.Timer();

        private bool isMouseHover = false;
        private bool IsTimerHoverChecking { get; set; } = false;
        public int TimerHoverDelay { get; set; } = 20;

        private void OnHoverTimerTick(object? sender, EventArgs e)
        {
            hoverEventTimer.Stop();
            IsTimerHoverChecking = false;
            setBorderOnHover(isMouseHover);
        }

        private void onHover(bool visible)
        {
            isMouseHover = visible;
            if (!IsTimerHoverChecking)
            {
                hoverEventTimer.Interval = TimerHoverDelay;
                hoverEventTimer.Tick += new EventHandler(OnHoverTimerTick);
                hoverEventTimer.Start();
                IsTimerHoverChecking = true;
            }
        }

        private void setBorderOnHover(bool visible)
        {
            if (visible)
            {
                this.BackColor = Color.FromArgb(48, 58, 72);
                this.Invalidate(true);
            }
            else
            {
                this.BackColor = Color.FromArgb(40, 49, 60);
                this.Invalidate(true);
            }
        }

        private void AddMouseHandlers(Control control)
        {
            control.Click += new EventHandler(clickOnThisControl);
            control.MouseEnter += new EventHandler((object? sender, EventArgs e) => { onHover(true); });
            control.MouseLeave += new EventHandler((object? sender, EventArgs e) => { onHover(false); });

            foreach (Control childControl in control.Controls)
            {
                AddMouseHandlers(childControl);
            }
        }

        #endregion
    }
}
