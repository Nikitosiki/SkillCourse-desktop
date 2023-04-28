using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //NameCourse = textName ?? string.Empty;
            //DescriptionCourse = textDescription ?? string.Empty;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(textBoxName);
            label2.Text = textBoxName.Text.Length.ToString() + " / 80";
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            ValidityCheckName(textBoxDescription);
            label4.Text = textBoxDescription.Text.Length.ToString() + " / 500";
        }

        private void ValidityCheckName(TextBox thisTextBox)
        {
            thisTextBox.Text = Regex.Replace(thisTextBox.Text, @"[\/\\\:\*\?\""\<\>\|]", "");
            thisTextBox.SelectionStart = thisTextBox.Text.Length;
            //thisTextBox.Invalidate();
        }
    }
}
