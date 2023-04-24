using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.Notification
{
    public partial class PanelMainBlock_MessageText : UserControl
    {
        public PanelMainBlock_MessageText(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }
    }
}
