using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            set { textBoxName.Text = value; }
        }
        public string DescriptionCourse
        {
            get
            {
                return textBoxDescription.Text;
            }
            set { textBoxDescription.Text = value; }
        }



        public Component_CreateCourse_Naming(string? textName, string? textDescription)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            NameCourse = textName ?? string.Empty;
            DescriptionCourse = textDescription ?? string.Empty;
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
