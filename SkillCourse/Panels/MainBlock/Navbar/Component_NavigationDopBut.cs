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
    public partial class Component_NavigationDopBut : UserControl
    {
        public Component_NavigationDopBut(string text)
        {
            InitializeComponent();
            button1.Text = text;
            Dock = DockStyle.Top;
        }
    }
}
