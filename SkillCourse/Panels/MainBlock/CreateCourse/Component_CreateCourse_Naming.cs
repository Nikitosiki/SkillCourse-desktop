using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillCourse.Panels.MainBlock.CreateCourse
{
    public partial class Component_CreateCourse_Naming : UserControl
    {
        public string NameCourse
        {
            get
            {
                return textBoxName.Text;
            }
        }
        public string DescriptionCourse
        {
            get
            {
                return textBoxDescription.Text;
            }
        }



        public Component_CreateCourse_Naming()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBoxName.Text.Length.ToString() + " / 80";
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBoxDescription.Text.Length.ToString() + " / 500";
        }
    }
}
