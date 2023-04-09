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
    public partial class Component_NavigationBut : UserControl
    {
        public Component_NavigationBut(string text, bool action)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            button1.Text = text;

            if (action)
                button1.ForeColor = SystemColors.ControlLight;
            else
                button1.ForeColor = Color.FromArgb(142, 173, 212);
        }
    }
}
