using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.PanelComponents.CoursePage
{
    public partial class Component_AddTask : UserControl
    {
        public string textButton
        {
            get { return customRoundedButton1.Text; }
            set { customRoundedButton1.Text = value; }
        }

        public Action AddButtonClick
        {
            get;
            set;
        }

        public Component_AddTask()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            AddButtonClick?.Invoke();
        }
    }
}
