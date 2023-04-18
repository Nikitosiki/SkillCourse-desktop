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

namespace SkillCourse.PanelComponents.UsersPage
{
    public partial class Component_UserText : UserControl
    {
        public Component_UserText(User user)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelText.Text = user.FirstName + " " + user.LastName;
            labelLast.Text = $"Last: {user.LastLoginDate.ToString("HH:mm d MMMM yyyy 'г.'")}";
        }
    }
}
