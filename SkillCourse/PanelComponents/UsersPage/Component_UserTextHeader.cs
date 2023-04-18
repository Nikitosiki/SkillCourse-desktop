using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents
{
    public partial class Component_UserTextHeader : UserControl
    {

        public Component_UserTextHeader(string text)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelText.Text = text;
        }

        public Component_UserTextHeader(string text, int countUsers)
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            labelText.Text = text;
            labelCount.Visible = countUsers > 0;
            labelCount.Text = $"{countUsers} Users";
        }
    }
}
