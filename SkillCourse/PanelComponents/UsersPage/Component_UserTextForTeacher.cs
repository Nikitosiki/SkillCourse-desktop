using CPProject.components.ui;
using SkillCourse.DataBaseStructure;
using SkillCourse.Forms;
using SkillCourse.handlers;
using SkillCourse.Panels.MainBlock;

namespace SkillCourse.PanelComponents.UsersPage
{
    public partial class Component_UserTextForTeacher : UserControl
    {
        private Course ThisCourse { get; set; }
        private User ThisUser { get; set; }
        public bool DeleteAvailable { get; set; } = true;

        private User userHandler = AccountHandler.Instance.UserLog;

        public Component_UserTextForTeacher(User user, Course course, bool defState)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            DeleteAvailable = defState;
            ThisUser = user;
            ThisCourse = course;
            Name = user.FirstName + " " + user.LastName;
            labelText.Text = user.FirstName + " " + user.LastName;


            if (user.Equals(AccountHandler.Instance.UserLog))
                labelLast.Text = "Online";
            else
                labelLast.Text = DateHelper.GetTimeDifferenceString(user.LastLoginDate);
            //labelLast.Text = $"Last: {user.LastLoginDate.ToString("HH:mm d MMMM yyyy 'г.'")}";

            AddMouseHandlers(this);
            ChangeButtonState();
        }

        public void AdminView(bool admin)
        {
            tableLayoutPanelAdmin.Visible = admin;
        }

        private void ChangeButtonState()
        {
            if (DeleteAvailable)
            {
                roundedButton.BackColor = Color.FromArgb(220, 50, 80);
                roundedButton.Image = Properties.Resources.close_white_24dp;
            }
            else
            {
                roundedButton.BackColor = Color.FromArgb(50, 65, 80);
                roundedButton.Image = Properties.Resources.outline_add_white_24dp;
            }
        }

        private void roundedButton_Click(object sender, EventArgs e)
        {
            if (DeleteAvailable)
            {
                ///.....
                UnSubscriptionStud();
            }
            else
            {
                ///.....
                SubscriptionStud();
            }
            DeleteAvailable ^= true;
            ChangeButtonState();
        }

        private void SubscriptionStud()
        {
            Teather handlers = (Teather)userHandler;
            handlers.SubscripStudentToCourse(ThisCourse, (Student)ThisUser);
            this.Tag = "";
        }

        private void UnSubscriptionStud()
        {
            string text = "Are you sure you want to remove this student from the course, will he lose all his answers? 🤨";
            Control oldMainParent = SetBaseParent();
            MessageYesNo modalForm = new MessageYesNo(text, new Size(oldMainParent.ClientSize.Width, oldMainParent.ClientSize.Height));
            modalForm.LoatLocationY = ((SystemInformation.CaptionHeight) / 2);
            DialogResult result = modalForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Teather handlers = (Teather)userHandler;
                handlers.UnSubscripStudentToCourse(ThisCourse, (Student)ThisUser);
                this.Tag = "Out";
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


        private void clickOnThis(object sender, EventArgs e)
        {
            NavigatePages.OpenNextPage(new PanelMainBlock_UserPage(ThisUser));
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
