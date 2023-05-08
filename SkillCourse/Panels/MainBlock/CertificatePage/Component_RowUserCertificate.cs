using CPProject.components.ui;
using SkillCourse.DataBaseStructure;
using SkillCourse.Forms;
using SkillCourse.handlers;
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

namespace SkillCourse.Panels.MainBlock.CertificatePage
{
    public partial class Component_RowUserCertificate : UserControl
    {
        public Teather handler = (Teather)AccountHandler.Instance.UserLog;
        public SubscriptionCourse ThisSub { get; private set; }

        public Component_RowUserCertificate(SubscriptionCourse sub, bool isWaiting)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            ThisSub = sub;
            Student stud = UserHandler.GetStudent(sub);

            labelStudName.Text = $"Student: {stud.FirstName} {stud.LastName}";
            labelText.Text = $"Course: \"{UserHandler.GetCourse(sub).Name}\"";
            StateProcentBar(handler.ProcentCompleteCourse(sub));
            ReSizeDescription();

            if (!isWaiting) tableLayoutPanel1.Hide();
            AddMouseHandlers(this);
        }

        private void StateProcentBar(int procent)
        {
            if (procent == 100)
            {
                labelStatus.Visible = false;
                panelButIssue.Visible = true;
            }
            else
                labelStatus.Text = procent + "%";
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

        private void newButtonIssue_Click(object sender, EventArgs e)
        {
            var thisParent = this.Parent;
            while (true)
            {
                if (thisParent.Parent == null)
                    break;

                thisParent = thisParent.Parent;
            }

            AnswerToTask answerForm = new AnswerToTask(new Size(thisParent.ClientSize.Width, thisParent.ClientSize.Height),
                String.Empty, UserTextSize.Certificate.maxLenghtDescription, false);
            answerForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = answerForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                handler.AddCertificate(ThisSub.IdCourse, ThisSub.IdStudent, answerForm.Text);


                // Говно код - не смотреть
                var parentObj = this.Parent;
                while (true)
                {
                    if (parentObj == null)
                        break;

                    if (parentObj is PanelMainBlock_CertificateForTeacher parent)
                    {
                        parent.UpdatePanel_OnSelectedIndexChanged();
                        break;
                    }
                    else
                        parentObj = parentObj.Parent;
                }
            }
        }


        private void clickOnThis(object sender, EventArgs e)
        {
            if (UserHandler.GetUser(ThisSub.IdStudent) is User user)
                NavigatePages.OpenNextPage(new PanelMainBlock_UserPage(user));
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
            control.Click += new EventHandler(clickOnThis);
            control.MouseEnter += new EventHandler((object? sender, EventArgs e) => { onHover(true); });
            control.MouseLeave += new EventHandler((object? sender, EventArgs e) => { onHover(false); });

            foreach (Control childControl in control.Controls)
            {
                if (!(childControl is CustomRoundedButton) && !(childControl is Button))
                    AddMouseHandlers(childControl);
            }
        }

        #endregion
    }
}
