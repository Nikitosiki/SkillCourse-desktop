using SkillCourse.DataBaseStructure;
using SkillCourse.handlers;
using SkillCourse.Panels.MainBlock;
using SkillCourse.Panels.MainBlock.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents.UsersPage
{
    public partial class Component_UserText : UserControl
    {
        private string UserLastName { get; set; } = "";
        private string UserFirstName { get; set; } = "";

        public Component_UserText(User user)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            UserLastName = user.LastName;
            UserFirstName = user.FirstName;
            Name = UserLastName + " " + UserFirstName;
            labelText.Text = UserFirstName + " " + UserLastName;

            if (user.Equals(AccountHandler.Instance.UserLog))
                labelLast.Text = "Online";
            else
                labelLast.Text = DateHandler.GetTimeDifferenceString(user.LastLoginDate);
                //labelLast.Text = $"Last: {user.LastLoginDate.ToString("HH:mm d MMMM yyyy 'г.'")}";

            AddMouseHandlers(this);
        }

        //public Component_UserText(User user, bool dfas)
        //{
        //    InitializeComponent();
        //    Dock = DockStyle.Top;

        //    Name = user.LastName + " " + user.FirstName;
        //    labelText.Text = user.FirstName + " " + user.LastName;
        //    if (user.Equals(AccountHandler.Instance.UserLog))
        //        labelLast.Text = "Online";
        //    else
        //        labelLast.Text = $"Last: {user.LastLoginDate.ToString("HH:mm d MMMM yyyy 'г.'")}";

        //    AddMouseHandlers(this);
        //}

        private void clickOnThis(object sender, EventArgs e)
        {
            User user = SkillCourseDB.Instance.Users.Find(us => us.FirstName == UserFirstName && us.LastName == UserLastName);
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
                AddMouseHandlers(childControl);
            }
        }

        #endregion
    }
}
